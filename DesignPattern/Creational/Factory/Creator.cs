using DesignPattern.Creational.Factory.Interfaces;
using DesignPattern.Creational.Factory.Models;

namespace DesignPattern.Creational.Factory
{
    public class Creator
    {
        public Creator()
        {
            Console.WriteLine("Creator Init!");
        }
        public IPurchase GetDatabase(string type)
        {

            IPurchase purchase = null;
            switch (type)
            {
                case "ZaloPay":
                    purchase = new Zalopay();
                    break;
                case "Momo":
                    purchase = new Momo();
                    break;
            }
            return purchase;
        }
    }
}
