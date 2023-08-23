namespace DesignPattern.SOLID.Single
{
    public class Student
    {
        public int Id { get; set; }
        private string name { get; set; }
        private string Class { get; set; }
        private List<string> SubjectRegistered { get; set; }
        public Student() { }
        //
        public void RegisterSubject(string subject)
        {

        }
        //
        public List<String> GetSubjectRegisteredList()
        {
            return this.SubjectRegistered;
        }
        // =>  Violate
        public bool CheckSubjectCondition()
        {
            return false;

        }

    }
}
