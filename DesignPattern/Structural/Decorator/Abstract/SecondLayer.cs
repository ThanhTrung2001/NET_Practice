using DesignPattern.Structural.Decorator.Interface;

namespace DesignPattern.Structural.Decorator.Abstract
{
    public class SecondLayer : Decorator
    {
        public SecondLayer(IAccountSecurity security) : base(security)
        {
        }

        public override void Login()
        {
            Console.Write("Second Layer password :");
            string x = Console.ReadLine();
            if (x == "2")
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
