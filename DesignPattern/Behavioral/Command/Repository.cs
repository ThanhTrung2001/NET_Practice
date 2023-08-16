namespace DesignPattern.Behavioral.Command
{
    public class Repository
    {
        private bool isChange;
        private static Repository Instance;
        public static Repository GetInstance()
        {
            if (Instance == null)
            {
                Instance = new Repository();
                Console.WriteLine("Repository has been created!");
            }
            return Instance;
        }
        public Repository()
        {
            isChange = false;
        }

        public void PullCode()
        {
            if (isChange != false)
            {
                this.isChange = false;
                Console.WriteLine("Pull code from repository");
            }
            else
            {
                Console.WriteLine("Nothing change to pull.");
            }

        }

        public void PushCode()
        {
            this.isChange = true;
            Console.WriteLine("Push code to repository");
        }
    }
}
