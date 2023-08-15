using DesignPattern.Creational.Factory.Interfaces;

namespace DesignPattern.Creational.Factory.Models
{
    public class Momo : IPurchase
    {
        public Momo()
        {
            Console.WriteLine("Momo connection init!");
        }
        public void CloseConnection()
        {
            Console.WriteLine("Close Connection!");
        }

        public void OpenConnection(int money)
        {
            Console.WriteLine("MySQL start connection!");
            Purchase(money);
            CloseConnection();
        }

        public void Purchase(int i)
        {
            Console.WriteLine($"ZaloPay - {i}k");
        }
    }
}
