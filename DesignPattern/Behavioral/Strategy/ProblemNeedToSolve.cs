using DesignPattern.Behavioral.Strategy.Interface;

namespace DesignPattern.Behavioral.Strategy
{
    public class ProblemNeedToSolve
    {
        protected IProblemSolving solveWay;
        public void SetProblemSovlingWay(IProblemSolving problemSolving)
        {
            this.solveWay = problemSolving;
        }
        public void Solve()
        {
            this.solveWay.Solving();
        }
    }
}
