namespace DesignPattern.Behavioral.Command.Interface
{
    public class PullFromRepo : ICommand
    {
        private Repository repository;
        public PullFromRepo(Repository repository)
        {
            this.repository = repository;
        }
        public void Do()
        {
            repository.PullCode();
        }
    }
}
