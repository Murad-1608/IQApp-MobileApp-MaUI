using IQApp.DataAccess.Abstract;
using IQApp.DataAccess.Entities;

namespace IQApp.DataAccess.Concrete
{
    public class QuestionRepository : IQuestionRepository
    {
        public Question GetByLevel(int level)
        {
            using (LocalDbService db = new LocalDbService())
            {
                return db.Connection.Table<Question>().FirstOrDefault(q => q.Level == level);
            }

        }
        public List<Question> GetAll()
        {
            using (LocalDbService db = new LocalDbService())
            {
                return db.Connection.Table<Question>().ToList();
            }
        }

        public void Add(Question question)
        {
            using (LocalDbService db = new LocalDbService())
            {
                db.Connection.Insert(question);
            }
        }

        public void Update(Question question)
        {
            using (LocalDbService db = new LocalDbService())
            {
                db.Connection.Update(question);
            }
        }
        public void ClearAll()
        {
            using (LocalDbService db = new LocalDbService())
            {
                db.Connection.DeleteAll<Question>();
            }
        }
    }
}
