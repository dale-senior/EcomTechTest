using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace EcomTechTest.Entities.helpers.Implementation
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected readonly EcomContext context;
        public Repository(EcomContext context)
        {
            thiscontext = context;
        }
        public T Add(T entity)
        {
            var dbEntity = context.Set<T>().Add(entity).Entity;
            SaveChanges();
            return dbEntity;
        }
        public void AddRange(IEnumerable<T> entities)
        {
            context.Set<T>().AddRange(entities);
            SaveChanges();
        }
        public IEnumerable<T> Find(Expression<Func<T, bool>> expression)
        {
            return context.Set<T>().Where(expression);
        }
        public IEnumerable<T> GetAll()
        {
            return context.Set<T>().ToList();
        }
        public T GetById(int id)
        {
            return context.Set<T>().Find(id);
        }
        public void Remove(T entity)
        {
            context.Set<T>().Remove(entity);
            SaveChanges();

        }
        public void RemoveRange(IEnumerable<T> entities)
        {
            context.Set<T>().RemoveRange(entities);
            SaveChanges();
        }

        public bool Exists(int id) 
        { 
            return context.Set<T>().Find(id) != null;
        }

        public void RemoveById(int id)
        {
            var entity = context.Set<T>().Find(id);
            if (entity != null)
            {
                Remove(entity);
                SaveChanges();
            }
        }

        public void SaveChanges() 
        {
            context.SaveChanges();
        }
    }
}
