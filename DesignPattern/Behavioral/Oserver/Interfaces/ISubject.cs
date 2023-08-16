namespace DesignPattern.Behavioral.Oserver.Interfaces
{
    public interface ISubject
    {
        void Subcribe(ISubcriber subcriber);
        void UnSubcribe(ISubcriber subcriber);
        void AddNotification();
        void NotifyForSubcriber(string message);
    }
}
