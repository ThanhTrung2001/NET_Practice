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
            Console.WriteLine("Begin Transaction");
        }

        public void Commit()
        {
            try
            {
                Console.WriteLine("Commit Transaction");
                transaction.Commit();

            }
            catch (Exception exception)
            {
                Console.WriteLine("Fail.Rollback Transaction");
                transaction.Rollback();
                throw exception;
            }
            finally
            {
                Console.WriteLine("Dispose Transaction");
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
            Console.WriteLine("Save Changes to Transaction");
            context.SaveChanges();
        }
    }
}