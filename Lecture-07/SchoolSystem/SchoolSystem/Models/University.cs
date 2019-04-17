using System.Collections.Generic;

namespace SchoolSystem.Models
{
    public class University
    {
        public int UniversityId { get; set; }
        public string UniName { get; set; }
        
        public List<Student> Students { get; set; }
    }
}