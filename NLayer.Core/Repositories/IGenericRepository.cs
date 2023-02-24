using System.Linq.Expressions;

namespace NLayer.Data_Repository.Repositories
{
    public interface IGenericRepository<T> where T : class,new()
    {
        Task<T> GetById (int id);
        IQueryable<T> GetAll();
        IQueryable<T> Where(Expression<Func<T, bool>> expression);
        Task<bool> AnyAsync(Expression<Func<T, bool>> expression);
        Task AddAsync(T entity);
        Task AddRangeAsync(IEnumerable<T> entity);
        void Update(T entity);
        void Remove(T entity);
        void RemoveRangeAsync(IEnumerable<T> entity);
    }
}
