using SchoolSystem.Models;

namespace SchoolSystem.Dtos
{
    public class UniversityDto
    {
        public string UniName { get; set; }

        public University ToDb()
        {
            if (string.IsNullOrWhiteSpace(UniName))
                return null;
            
            return new University
            {
                UniName = UniName
            };
        }
    }
}