using DesignPattern.Behavioral.Mediator.Interface;

namespace DesignPattern.Behavioral.Mediator
{
    public class Green : TrafficLightComponent
    {
        public void TurnOn()
        {
            this.mediator.Notify("Green");
        }
        public void Switch()
        {
            this.mediator.Notify("Yellow");
        }
    }
}
