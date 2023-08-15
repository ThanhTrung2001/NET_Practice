namespace DesignPattern.Structural.Decorator.Interface
{
    public class Account : IAccountSecurity
    {
        public Account() { }
        public void Login()
        {
            Console.WriteLine("No more Security Layer, Login Complete!");
        }
    }
}
