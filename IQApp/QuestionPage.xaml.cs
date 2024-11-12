using IQApp.DataAccess.Abstract;
using IQApp.DataAccess.Entities;

namespace IQApp;

public partial class QuestionPage : ContentPage
{
    private readonly IUnitOfWork _unitOfWork;
    private Question _question;
    public QuestionPage(int questionLevel, IUnitOfWork unitOfWork)
    {

        InitializeComponent();
        this.Title = $"Level {questionLevel}";
        _unitOfWork = unitOfWork;

        FillParameters(questionLevel);
    }

    private void FillParameters(int questionNum)
    {
        _question = _unitOfWork.QuestionRepository.GetByLevel(questionNum);

        LblQuestion.Text = _question.Content;
    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        if (txt_Answer.Text == _question.Answer)
        {
            if (_question.Level == 100)
            {
                return;
            }
            // Novbeti sual
            Question nextQuestion = _unitOfWork.QuestionRepository.GetByLevel(_question.Level + 1);
            nextQuestion.IsCompleted = true;
            _unitOfWork.QuestionRepository.Update(nextQuestion);

            SuccessPage successPage = new SuccessPage(_unitOfWork, nextQuestion.Level);
            await Navigation.PushAsync(successPage);
            var previousPage = Navigation.NavigationStack[Navigation.NavigationStack.Count - 2];
            Navigation.RemovePage(previousPage);

            return;
        }
        await DisplayAlert("Xəta", "Cavab düzgün deyildir.", "Ok");

    }
}