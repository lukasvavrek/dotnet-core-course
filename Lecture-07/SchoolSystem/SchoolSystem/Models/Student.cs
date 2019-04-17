namespace SchoolSystem.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        
        public int UniversityId { get; set; }
        public University University { get; set; }
    }
}