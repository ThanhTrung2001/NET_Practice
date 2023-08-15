namespace DesignPattern.Creational.Factory.Interfaces
{
    public interface IPurchase
    {
        void OpenConnection(int i);
        void Purchase(int i);
        void CloseConnection();
    }
}
