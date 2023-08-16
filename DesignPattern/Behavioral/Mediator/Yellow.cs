using DesignPattern.Behavioral.Mediator.Interface;

namespace DesignPattern.Behavioral.Mediator
{
    public class Yellow : TrafficLightComponent
    {
        public void TurnOn()
        {
            this.mediator.Notify("Yellow");
        }
        public void Switch()
        {
            this.mediator.Notify("Red");

        }
    }
}
