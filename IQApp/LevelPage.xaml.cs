using IQApp.DataAccess.Abstract;
using IQApp.DataAccess.Concrete;
using IQApp.DataAccess.Entities;

namespace IQApp;

public partial class LevelPage : ContentPage
{
    private readonly IUnitOfWork _unitOfWork;
    public LevelPage(IUnitOfWork unitOfWork)
    {
        InitializeComponent();
        _unitOfWork = unitOfWork;

        CreateButtons();
    }

    private void CreateButtons()
    {
        var questions = _unitOfWork.QuestionRepository.GetAll();

        int buttonCount = questions.Count;
        int columns = 4;
        int rows = (int)Math.Ceiling((double)buttonCount / columns);

        for (int i = 0; i < rows; i++)
        {
            this.GridPanel.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });
        }
        for (int i = 0; i < columns; i++)
        {
            this.GridPanel.ColumnDefinitions.Add(new ColumnDefinition { Width = GridLength.Star });
        }

        for (int i = 0; i < buttonCount; i++)
        {
            var button = new Button
            {
                WidthRequest = 80,
                HeightRequest = 40,
                Text = $"{i + 1}"
            };

            if (!questions[i].IsCompleted)
                button.IsEnabled = false;


            button.Clicked += (sender, e) => OnButtonClicked(sender, e);


            int row = i / columns;
            int column = i % columns;

            Grid.SetRow(button, row);
            Grid.SetColumn(button, column);

            this.GridPanel.Children.Add(button);
        }
    }
    private async void OnButtonClicked(object sender, EventArgs e)
    {
        Button clickedButton = (Button)sender;

        await Navigation.PushAsync(new QuestionPage(Convert.ToInt32(clickedButton.Text), _unitOfWork));
    }

    private void GenerateQuestions()
    {


        Question q1 = new Question()
        {
            Id = 1,
            Answer = "69",
            Level = 1,
            Content = "★123 = 14      ★246 = 56\n" +
                      "★157 = 75      ★812 = ?",
            IsCompleted = true
        };

        _unitOfWork.QuestionRepository.Add(q1);

        Question q2 = new Question()
        {
            Id = 2,
            Answer = "96",
            Level = 2,
            Content = "14 # 23 = 55      25 # 34 = 77\n" +
                      "36 # 23 = 95      45 # 24 = ?",
            IsCompleted = false
        };

        _unitOfWork.QuestionRepository.Add(q2);

        Question q3 = new Question()
        {
            Id = 3,
            Answer = "18",
            Level = 3,
            Content = "14 ▲ 8 = 12      26 ▲ 12 = 28\n" +
                      "13 ▲ 5 = 16      21 ▲ 12 = ?",
            IsCompleted = false
        };

        _unitOfWork.QuestionRepository.Add(q3);



        Question q4 = new Question()
        {
            Id = 4,
            Answer = "24",
            Level = 4,
            Content = "6 , 12 , 8 , 16 , 12 , ? , 20",
            IsCompleted = false
        };

        _unitOfWork.QuestionRepository.Add(q4);


        Question q5 = new Question()
        {
            Id = 4,
            Answer = "24",
            Level = 4,
            Content = "7 (128) 2      3 (125) 5\n" +
                      "4 (256) 4      3 ( ? ) 7",
            IsCompleted = false
        };

        _unitOfWork.QuestionRepository.Add(q5);
    }
}

