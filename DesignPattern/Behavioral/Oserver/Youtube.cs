using DesignPattern.Behavioral.Oserver.Interfaces;

namespace DesignPattern.Behavioral.Oserver
{
    public class Youtube : ISubject
    {
        private List<ISubcriber> subcribers;
        public Youtube()
        {
            this.subcribers = [];
        }

        public void Subcribe(ISubcriber subcriber)
        {
            this.subcribers.Add(subcriber);
        }

        public void UnSubcribe(ISubcriber subcriber)
        {
            this.subcribers.Remove(subcriber);
        }

        public void AddNotification()
        {
            Console.Write("Send Notification for subcribers: ");
            while (true)
            {
                string message = Console.ReadLine();
                if (message != "")
                {
                    NotifyForSubcriber(message);
                    break;
                }
            }

            Console.WriteLine("---------------");
        }

        public void NotifyForSubcriber(string message)
        {
            foreach (var subcriber in subcribers)
            {
                subcriber.Update(message);
            }
        }
    }
}
