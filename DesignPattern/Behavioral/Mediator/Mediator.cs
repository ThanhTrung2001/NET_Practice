using DesignPattern.Behavioral.Mediator.Interface;

namespace DesignPattern.Behavioral.Mediator
{
    public class Mediator : IMediator
    {
        TrafficLightComponent redLight;
        TrafficLightComponent yellowLight;
        TrafficLightComponent greenLight;
        public Mediator(TrafficLightComponent redLight, TrafficLightComponent yellowLight, TrafficLightComponent greenLight)
        {
            this.redLight = redLight;
            redLight.SetMediator(this);
            this.yellowLight = yellowLight;
            yellowLight.SetMediator(this);
            this.greenLight = greenLight;
            greenLight.SetMediator(this);
        }
        public void Notify(string message)
        {
            switch (message)
            {
                case "Red":
                    Console.WriteLine("Stop moving, waiting for green color!");
                    break;
                case "Yellow":
                    Console.WriteLine("Moving slow, almost stop when red turn on!");
                    break;
                case "Green":
                    Console.WriteLine("Moving like normal!");
                    break;
            }
        }
    }
}
