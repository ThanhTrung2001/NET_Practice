namespace DesignPattern.Structural.Adapter
{
    public class NoteAdaptee
    {
        public void LogTheNote(Note note)
        {
            Console.WriteLine("Note");
            Console.WriteLine(note.userId);
            Console.WriteLine(note.id);
            Console.WriteLine(note.title);
            Console.WriteLine(note.completed);



        }
    }
}
