namespace DesignPattern.Structural.Adapter
{
    //Adaptee - Note
    public class Note
    {
        public int userId { get; set; }
        public int id { get; set; }
        public string title { get; set; }
        public bool completed { get; set; }
        public Note() { }
    }
}
