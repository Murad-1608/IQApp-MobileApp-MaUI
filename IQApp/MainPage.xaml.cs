using IQApp.DataAccess.Abstract;
using IQApp.DataAccess.Concrete;

namespace IQApp
{
    public partial class MainPage : ContentPage
    {
        private readonly IUnitOfWork _unitOfWork;
        public MainPage(IUnitOfWork unitOfWork)
        {
            InitializeComponent();
            _unitOfWork = unitOfWork;
        }

        private void CounterBtn1_Clicked(object sender, EventArgs e)
        {
            LevelPage levelPage = new LevelPage(_unitOfWork);

            Navigation.PushAsync(levelPage);
        }
    }

}
