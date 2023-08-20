using Microsoft.EntityFrameworkCore;
using SpecialDP.Data.Repository.Interface;
using SpecialDP.Models;

namespace SpecialDP.Data.Repository
{
    public class CardRepository : GenericRepository<Card>, ICardRepository
    {
        //public CardRepository(ApplicationDbContext context) : base(context)
        //{
        //}

        public CardRepository(DbContext context) : base(context)
        {
        }

        public IEnumerable<Card> FindByName(string name)
        {
            return this.dbSet.Where(x => x.Name.Contains(name));
        }

        public IEnumerable<Card> FindByStar(int star)
        {
            return this.dbSet.Where(x => x.Stars == star);
        }
    }
}
