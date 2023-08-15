using DesignPattern.Structural.Bridge.Interface;

namespace DesignPattern.Structural.Bridge
{
    public abstract class Developer
    {
        protected IJob job;
        public Developer(IJob job)
        {
            this.job = job;
        }
        public abstract void WillWorkWith();
    }
}
