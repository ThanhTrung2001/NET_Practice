namespace DesignPattern.Structural.Facade.SubSystems
{
    public class RadarService : IAirspaceDefend
    {
        public void DoJob(bool stop)
        {
            if (stop == false)
            {
                string x = Console.ReadLine();
                if (x == "")
                {
                    Console.WriteLine("Some Plane have pervade our country's airspace!");
                    return;
                }
                stop = true;
                Console.WriteLine("Nothing happens...");
            }

        }
    }
}
