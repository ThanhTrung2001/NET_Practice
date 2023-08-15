using DesignPattern.Structural.Bridge.Interface;

namespace DesignPattern.Structural.Bridge
{
    public class BEDev : Developer
    {
        public BEDev(IJob job) : base(job)
        {
        }

        public override void WillWorkWith()
        {
            Console.Write("BEDev will work with ");
            job.Dojob();
        }
    }
}
