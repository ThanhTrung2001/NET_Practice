using Microsoft.EntityFrameworkCore.Storage;
using SpecialDP.Data.Repository;
using SpecialDP.Data.Repository.Interface;

namespace SpecialDP.Data.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        protected readonly ApplicationDbContext context;
        private IDbContextTransaction transaction;

        public UnitOfWork(ApplicationDbContext _context)
        {
            context = _context;
            transaction = null;
        }

        public IGenericRepository<T> GetRepository<T>() where T : class
        {
            return new GenericRepository<T>(context);
        }


        public CardRepository GetCardRepository()
        {
            return new CardRepository(context);
        }

        public void CreateTransaction()
        {
            transaction = context.Database.BeginTransaction();
        }

        public void Commit()
        {
            try
            {
                transaction.Commit();

            }
            catch (Exception exception)
            {
                transaction.Rollback();
                throw exception;
            }
            finally
            {
                transaction.Dispose();
                transaction = null;
            }
        }

        public void Rollback()
        {
            try
            {
                transaction.Rollback();
            }
            finally
            {
                transaction.Dispose();
                transaction = null;
            }
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }
}