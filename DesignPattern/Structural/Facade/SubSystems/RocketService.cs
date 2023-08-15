namespace DesignPattern.Structural.Facade.SubSystems
{
    public class RocketService : IAirspaceDefend
    {

        public void DoJob(bool stop)
        {
            if (stop == false)
            {
                Console.WriteLine("Countdown for 10 seconds before shoot them down.");
                Console.WriteLine("10...9...8...7...6...5...4...3........");
                string x = Console.ReadLine();
                if (x == "")
                {
                    Console.WriteLine("Fire!!!!");
                    return;
                }
                stop = true;
                Console.WriteLine(".............................");
                Console.WriteLine("They have left! Thanks God...");
            }

        }
    }
}
