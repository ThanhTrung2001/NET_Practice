namespace DesignPattern.Creational.Singleton
{
    public class SingletonRunner
    {
        public SingletonRunner() { }

        public void RunSingleTon()
        {

            var singleton1 = SingletonService.GetInstance();
            var singleton2 = SingletonService.GetInstance();
            //
            singleton1.PlusOne();
            singleton2.PlusOne();
            //
            singleton1.PrintI();
            singleton2.PrintI();

            if (singleton1 == singleton2)
            {
                Console.WriteLine("these 2 variables is One.");
            }
        }
    }
}
