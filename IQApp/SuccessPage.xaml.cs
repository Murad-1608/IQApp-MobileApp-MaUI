using IQApp.DataAccess.Abstract;
using IQApp.DataAccess.Concrete;

namespace IQApp;

public partial class SuccessPage : ContentPage
{
    private readonly IUnitOfWork _unitOfWork;
    int _nexQuestionLevel;
    public SuccessPage(IUnitOfWork unitOfWork, int nextQuestionLevel)
    {
        InitializeComponent();
        _nexQuestionLevel = nextQuestionLevel;
        _unitOfWork = unitOfWork;
    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new QuestionPage(_nexQuestionLevel, _unitOfWork));

        var previousPage = Navigation.NavigationStack[Navigation.NavigationStack.Count - 2];
        Navigation.RemovePage(previousPage);
    }

}