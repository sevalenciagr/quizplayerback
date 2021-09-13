using QuizPlayer.Domain.Entities;

namespace QuizPlayer.Domain.Interfaces.Repositories
{
    public interface IBaseRepository<T>: IQueryRepository<T> where T : BaseEntity
    {
        long Insert(T entity);

        void Delete(T entity);

        void Update(T entity);
    }
}
