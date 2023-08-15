using DesignPattern.Structural.Bridge.Interface;

namespace DesignPattern.Structural.Bridge
{
    public class FEDev : Developer
    {
        public FEDev(IJob job) : base(job)
        {
        }

        public override void WillWorkWith()
        {
            Console.Write("FEDev will work with ");
            job.Dojob();
        }
    }
}
