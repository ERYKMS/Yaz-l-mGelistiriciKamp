using System.Linq.Expressions;

namespace Core.DataAccess
{
    public interface IEntityRepository<T>where T : class,new()
    {
        List<T> GetByAll(Expression<Func<T, bool>> filter = null);
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
    }
}
