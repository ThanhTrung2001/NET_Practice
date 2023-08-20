using SpecialDP.Models;

namespace SpecialDP.Data.Repository.Interface
{
    public interface ICardRepository : IGenericRepository<Card>
    {
        IEnumerable<Card> FindByName(string name);
        IEnumerable<Card> FindByStar(int star);
    }
}
