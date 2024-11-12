namespace IQApp.DataAccess.Abstract
{
    public interface IUnitOfWork
    {
        public IQuestionRepository QuestionRepository { get; }
        void Test();
    }
}
