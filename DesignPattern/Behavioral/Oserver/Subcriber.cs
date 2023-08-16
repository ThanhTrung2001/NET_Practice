using DesignPattern.Behavioral.Oserver.Interfaces;

namespace DesignPattern.Behavioral.Oserver
{
    public class Subcriber : ISubcriber
    {
        private int id;
        public Subcriber(int id)
        {
            this.id = id;
        }
        public void Update(string message)
        {
            Console.WriteLine($"Notification for subcriber{id} from Youtube Channel : {message}");
        }
    }
}
