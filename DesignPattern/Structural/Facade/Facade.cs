using DesignPattern.Structural.Facade.SubSystems;

namespace DesignPattern.Structural.Facade
{
    public class Facade
    {
        private static Facade Instance;
        private bool stop;
        private RadarService radarService;
        private NotificationService notificationService;
        private RocketService rocketService;
        public Facade()
        {
            Console.WriteLine("Facade AirDefender Ready!");
            this.radarService = new RadarService();
            this.notificationService = new NotificationService();
            this.rocketService = new RocketService();
        }

        public void DefendAirSpace()
        {
            radarService.DoJob(stop);
            notificationService.DoJob(stop);
            rocketService.DoJob(stop);
        }

        public static Facade GetInstance()
        {
            if (Instance == null)
            {
                Instance = new Facade();
                Console.WriteLine("Facade Instance has been created!");
            }
            return Instance;
        }




    }
}
