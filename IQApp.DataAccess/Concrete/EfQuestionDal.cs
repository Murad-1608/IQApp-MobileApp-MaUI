using IQApp.DataAccess.Abstract;
using IQApp.DataAccess.Entities;

namespace IQApp.DataAccess.Concrete
{
    public class EfQuestionDal : EfRepositoryBase<Question, AppDbContext>, IQuestionRepository
    {
    }
}
