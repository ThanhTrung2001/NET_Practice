using DesignPattern.Creational.Factory.Interfaces;

namespace DesignPattern.Creational.Factory.Models
{
    public class Zalopay : IPurchase
    {
        public Zalopay()
        {
            Console.WriteLine("Zalo connection init!");
        }

        public void CloseConnection()
        {
            Console.WriteLine("Close Connection!");
        }

        public void OpenConnection(int money)
        {
            Console.WriteLine("ZaloPay start connection!");
            Purchase(money);
            CloseConnection();
        }

        public void Purchase(int i)
        {
            Console.WriteLine($"ZaloPay - {i}k");
        }
    }
}
