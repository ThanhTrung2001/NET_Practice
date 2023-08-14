namespace DesignPattern.Creational.Singleton
{
    public class SingletonService
    {
        private static SingletonService Instance;
        private int i = 0;

        public SingletonService() { }

        public static SingletonService GetInstance()
        {
            if (Instance == null)
            {
                Instance = new SingletonService();
                Console.WriteLine("SingleService has been created!");
            }
            return Instance;
        }

        public void PlusOne()
        {
            i++;
        }

        public void PrintI()
        {
            Console.WriteLine(i);
        }
    }
}
