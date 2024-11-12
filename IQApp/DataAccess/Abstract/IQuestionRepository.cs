using IQApp.DataAccess.Entities;

namespace IQApp.DataAccess.Abstract
{
    public interface IQuestionRepository
    {
        Question GetByLevel(int level);
        List<Question> GetAll();
        void Add(Question question);
        void Update(Question question);
        void ClearAll();
    }
}
