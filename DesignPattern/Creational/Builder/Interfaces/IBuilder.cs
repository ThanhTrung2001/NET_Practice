using DesignPattern.Creational.Factory.Interfaces;

namespace DesignPattern.Creational.Builder.Interfaces
{
    public interface IBuilder
    {
        void AddMomoPurchase();
        void AddZaloPayPurchase();
        List<IPurchase> GetList();
    }
}
