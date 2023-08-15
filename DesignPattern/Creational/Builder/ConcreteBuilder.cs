using DesignPattern.Creational.Builder.Interfaces;
using DesignPattern.Creational.Factory.Interfaces;

namespace DesignPattern.Creational.Builder
{
    public class ConcreteBuilder : IBuilder
    {

        public void AddMomoPurchase()
        {
            var list = PurchaseWay.GetInstance();
            list.AddPurchaseWay("Momo");
        }

        public void AddZaloPayPurchase()
        {
            var list = PurchaseWay.GetInstance();
            list.AddPurchaseWay("ZaloPay");
        }

        public List<IPurchase> GetList()
        {
            var list = PurchaseWay.GetInstance();
            foreach (var item in list.purchaseWays)
            {

                Console.WriteLine(item);
            }
            return list.GetPurchaseWays();
        }

    }
}
