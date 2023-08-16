using DesignPattern.Behavioral.Strategy.Interface;

namespace DesignPattern.Behavioral.Strategy
{
    public class WayOne : IProblemSolving
    {
        public void Solving()
        {
            Console.WriteLine("Solve by Way 1");
        }
    }
}
