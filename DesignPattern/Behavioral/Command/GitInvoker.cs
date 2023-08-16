using DesignPattern.Behavioral.Command.Interface;

namespace DesignPattern.Behavioral.Command
{
    public class GitInvoker
    {
        private ICommand pushCode;
        private ICommand pullCode;

        public GitInvoker(ICommand push, ICommand pull)
        {
            this.pushCode = push;
            this.pullCode = pull;
        }
        public void Push()
        {
            this.pushCode.Do();
        }

        public void Pull()
        {
            this.pullCode.Do();
        }
    }
}
