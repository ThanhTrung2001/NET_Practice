using SpecialDP.Data.Repository;
using SpecialDP.Data.Repository.Interface;

namespace SpecialDP.Data.UnitOfWork
{
    public interface IUnitOfWork
    {
        IGenericRepository<T> GetRepository<T>() where T : class;
        CardRepository GetCardRepository();
        //Create the database Transaction
        void CreateTransaction();
        //Commit the database Transaction
        void Commit();
        //Rollback the database Transaction
        void Rollback();
        //DbContext Class SaveChanges method
        void Save();
    }
}
