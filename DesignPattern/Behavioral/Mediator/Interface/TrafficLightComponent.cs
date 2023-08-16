namespace DesignPattern.Behavioral.Mediator.Interface
{
    public abstract class TrafficLightComponent
    {
        protected IMediator mediator;

        public void SetMediator(IMediator mediator)
        {
            this.mediator = mediator;
        }
    }
}
