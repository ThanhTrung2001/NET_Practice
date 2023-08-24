using TestingProject.Models;

namespace TestingProject.Data
{
    public class CardRepository : ICardRepository
    {

        private List<Card> cards;

        public CardRepository()
        {
            cards = new List<Card> {
                new Card{Id="1", Name="Card 1", Stars=1, Description="This is Card Number.1", Type="Pure", Price=100 },
                new Card{Id="2", Name="Card 2", Stars=2, Description="This is Card Number.2", Type="Normal", Price=200 },
                new Card{Id="3", Name="Card 3", Stars=3, Description="This is Card Number.3", Type="High", Price=300 },
                new Card{Id="4", Name="card 4", Stars=4, Description="This is Card Number.4", Type="Special", Price=400 },
                new Card{Id="5", Name="Card 5", Stars=5, Description="This is Card Number.5", Type="Legendary", Price=500 },
            };
        }

        public IEnumerable<Card> GetCards()
        {
            return cards.ToList();
        }

        public Card GetCardById(string id)
        {
            return cards.Find(x => x.Id == id);
        }

        public IEnumerable<Card> GetCardByName(string name)
        {
            throw new NotImplementedException();
        }

        public void Insert(Card obj)
        {
            cards.Add(obj);
        }

        public void Update(Card obj)
        {
            int index = cards.FindIndex(x => x.Id == obj.Id);
            cards[index] = obj;
        }

        public void Delete(Card obj)
        {
            cards.Remove(obj);
        }
    }
}
