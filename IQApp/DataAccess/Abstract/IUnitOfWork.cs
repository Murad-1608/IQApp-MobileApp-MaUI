namespace IQApp.DataAccess.Abstract
{
    public interface IUnitOfWork
    {
        IQuestionRepository QuestionRepository { get; }
    }
}
