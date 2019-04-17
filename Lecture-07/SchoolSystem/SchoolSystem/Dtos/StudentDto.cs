using SchoolSystem.Models;

namespace SchoolSystem.Dtos
{
    public class StudentDto
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        
        public Student ToDb()
        {
            if (string.IsNullOrWhiteSpace(Name) ||
                string.IsNullOrWhiteSpace(Surname) ||
                Age < 0)
                return null;
            
            return new Student
            {
                Name = Name,
                Surname = Surname,
                Age = Age
            };
        }
    }
}