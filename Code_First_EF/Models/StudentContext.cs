using System.Data.Entity;

namespace Code_First_EF.Models
{
    public class StudentContext : DbContext
    {
        public StudentContext() : base("StudentContext")
        {
        }
        public DbSet<Student> Students { get; set; }
    }
}