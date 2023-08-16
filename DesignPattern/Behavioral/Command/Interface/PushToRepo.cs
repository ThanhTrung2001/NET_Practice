namespace DesignPattern.Behavioral.Command.Interface
{
    public class PushToRepo : ICommand
    {
        private Repository repository;
        public PushToRepo(Repository repository)
        {
            this.repository = repository;
        }

        public void Do()
        {
            repository.PushCode();
        }
    }
}
