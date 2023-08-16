using DesignPattern.Creational.Factory.Interfaces;
using DesignPattern.Creational.Factory.Models;

namespace DesignPattern.Creational.Builder
{
    public class PurchaseWay  //Product
    {
        private List<IPurchase> purchaseWays = [];
        private static PurchaseWay? Instance;
        public PurchaseWay() { }
        public static PurchaseWay GetInstance()
        {
            if (Instance == null)
            {
                Instance = new PurchaseWay();
                Console.WriteLine("Singleton PurchaseWay has been created!");
            }
            return Instance;
        }

        public void AddPurchaseWay(string type)
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
            purchaseWays.Add(purchase);
        }

        public List<IPurchase> GetPurchaseWays()
        {
            return purchaseWays;
        }


    }
}
