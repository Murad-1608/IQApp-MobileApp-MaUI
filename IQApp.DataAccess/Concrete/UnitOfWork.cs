using IQApp.DataAccess.Abstract;

namespace IQApp.DataAccess.Concrete
{
    public class UnitOfWork : IUnitOfWork
    {
        public IQuestionRepository QuestionRepository => new EfQuestionDal();

        public void Test()
        {
            AppDbContext dbContext = new AppDbContext();

            var test = dbContext.Questions.ToList();
        }
    }
}
