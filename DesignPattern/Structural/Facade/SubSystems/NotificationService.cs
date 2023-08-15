namespace DesignPattern.Structural.Facade.SubSystems
{
    public class NotificationService
    {
        public void DoJob(bool stop)
        {
            if (stop == false)
            {
                Console.WriteLine("Notify that they must left our airspace!");
                string x = Console.ReadLine();
                if (x == "")
                {
                    Console.WriteLine("Alo alo, 1234!");
                    Console.WriteLine("Alo alo, 1234!");
                    Console.WriteLine("Alo alo, 1234!");
                    return;
                }
                stop = true;
                Console.WriteLine(".............................");
                Console.WriteLine("They have left! Thanks God...");
            }
        }
    }
}
