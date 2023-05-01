using System.Linq.Expressions;
using System.Security.Claims;

namespace EcomTechTest.Entities.helpers
{
    public interface IRepository<T> where T : class
    {
        T GetById(int id);
        IEnumerable<T> GetAll();
        IEnumerable<T> Find(Expression<Func<T, bool>> expression);
        T Add(T entity);
        void AddRange(IEnumerable<T> entities);
        void Remove(T entity);
        void RemoveById (int id);
        void RemoveRange(IEnumerable<T> entities);

        bool Exists(int id);

        void SaveChanges();
    }
}
