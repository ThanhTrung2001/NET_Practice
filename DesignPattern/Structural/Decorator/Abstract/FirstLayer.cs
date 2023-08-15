using DesignPattern.Structural.Decorator.Interface;

namespace DesignPattern.Structural.Decorator.Abstract
{
    public class FirstLayer : Decorator
    {
        public FirstLayer(IAccountSecurity security) : base(security)
        {
        }

        public override void Login()
        {
            Console.Write("Last Layer password :");
            string x = Console.ReadLine();
            if (x == "1")
            {
                Console.WriteLine("Accept Key! Continue...");
                base.Login();
            }
            else
            {
                Console.WriteLine("Wrong Key. Get out!");
            }

        }
    }
}
