using Microsoft.EntityFrameworkCore;
using SpecialDP.Data.Repository.Interface;

namespace SpecialDP.Data.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        //protected DbContext dbContext;
        //protected DbSet<T> dbSet;

        //public GenericRepository(DbContext context)
        //{
        //    this.dbContext = context;
        //    dbSet = context.Set<T>();
        //}

        protected readonly ApplicationDbContext dbContext;
        protected DbSet<T> dbSet;

        public GenericRepository(ApplicationDbContext context)
        {
            this.dbContext = context;
            dbSet = context.Set<T>();
        }

        public IEnumerable<T> GetAll()
        {
            return dbSet.ToList();
        }

        public T GetById(string id)
        {
            return dbSet.Find(id)!;
        }

        public void Add(T obj)
        {
            dbSet.Add(obj);
        }

        public void Update(T obj)
        {
            dbSet.Update(obj);
        }

        public void Delete(T obj)
        {
            dbSet.Remove(obj);
        }
    }
}
