using Microsoft.EntityFrameworkCore;

namespace SchoolSystem.Models
{
    public class UniversityContext : DbContext
    {
        public DbSet<University> Universities { get; set; }
        public DbSet<Student> Students { get; set; }

        public UniversityContext(DbContextOptions<UniversityContext> options)
            : base(options)
        {
        }
    }
}