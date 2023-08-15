using DesignPattern.Structural.Decorator.Interface;

namespace DesignPattern.Structural.Decorator.Abstract
{
    public class ThirdLayer : Decorator
    {
        public ThirdLayer(IAccountSecurity security) : base(security)
        {
        }

        public override void Login()
        {
            Console.Write("First Layer password :");
            string x = Console.ReadLine();
            if (x == "3")
            {
                Console.WriteLine("Accept Key! Continue...");
                base.Login();
            }
            else
            {
                Console.WriteLine("Wrong Key.Get out!");
            }

        }
    }
}
