using System.Linq.Expressions;

namespace SandBox_MVC.Contracts
{
    public interface IGenericRepository<T>
    {
        T GetFirstOrDefault(Expression<Func<T, bool>> filter, string? includeProperties = null);
        IEnumerable<T> GetAll(Expression<Func<T, bool>>? filter = null, string? includeProperties = null);

        void Remove(T entity);
        void Add(T entity);

        void Update(T entity);  
        void RemoveRange(IEnumerable<T> entity);

        


    }
}
