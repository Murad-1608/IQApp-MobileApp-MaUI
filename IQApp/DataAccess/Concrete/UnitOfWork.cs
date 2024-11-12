using IQApp.DataAccess.Abstract;

namespace IQApp.DataAccess.Concrete
{
    public class UnitOfWork : IUnitOfWork
    {
        public IQuestionRepository QuestionRepository => new QuestionRepository();
    }
}
