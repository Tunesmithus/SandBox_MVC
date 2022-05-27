using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using SandBox_MVC.Contracts;
using SandBox_MVC.Data;
using System.Linq.Expressions;

namespace SandBox_MVC.Repositories
{
    
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly ApplicationDbContext context;
        internal DbSet<T> dbSet;
        public GenericRepository(ApplicationDbContext context)
        {
            this.context = context;
            this.dbSet = context.Set<T>();

        }


        public void Add(T entity)
        {
            dbSet.Add(entity);
            context.SaveChanges();
        }

        

        public IEnumerable<T> GetAll(Expression<Func<T, bool>>? filter = null, string? includeProperties = null)
        {
            IQueryable<T> query = dbSet;
            if (filter != null)
            {
                query = query.Where(filter);
            }

            if (includeProperties != null)
            {
                foreach (var includeProp in includeProperties.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    query = query.Include(includeProp);
                }
            }
            return query.ToList();
        }

        public T GetFirstOrDefault(Expression<Func<T, bool>> filter, string? includeProperties = null)
        {
            IQueryable<T> query = dbSet;

            query = query.Where(filter);

            if (includeProperties != null)
            {
                foreach (var includeProp in includeProperties.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    query = query.Include(includeProp);
                }
            }

            return query.FirstOrDefault();
        }

        public void Remove(T entity)
        {
            dbSet.Remove(entity);
            context.SaveChanges();
        }

        public void RemoveRange(IEnumerable<T> entity)
        {
            dbSet.RemoveRange(entity);
            context.SaveChanges();
        }

        public void Update(T entity)
        {
            dbSet.Update(entity);
            context.SaveChanges();
        }
    }
}
