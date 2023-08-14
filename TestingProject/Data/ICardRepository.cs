using TestingProject.Models;

namespace TestingProject.Data
{
    public interface ICardRepository
    {
        public IEnumerable<Card> GetCards();

        public Card GetCardById(string id);

        public IEnumerable<Card> GetCardByName(string name);


        public void Insert(Card obj);


        public void Update(Card obj);


        public void Delete(Card obj);

    }
}
