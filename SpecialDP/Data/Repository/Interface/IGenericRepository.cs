namespace SpecialDP.Data.Repository.Interface
{
    public interface IGenericRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        T GetById(string id);
        void Add(T obj);
        void Update(T obj);
        void Delete(T obj);
    }
}
