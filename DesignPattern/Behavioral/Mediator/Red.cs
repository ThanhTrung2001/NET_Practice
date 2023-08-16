using DesignPattern.Behavioral.Mediator.Interface;

namespace DesignPattern.Behavioral.Mediator
{
    public class Red : TrafficLightComponent
    {
        public void TurnOn()
        {
            this.mediator.Notify("Red");
        }
        public void Switch()
        {

            this.mediator.Notify("Green");
        }
    }
}
