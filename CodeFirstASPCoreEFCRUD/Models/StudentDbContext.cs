using Microsoft.EntityFrameworkCore;

namespace CodeFirstASPCoreEFCRUD.Models
{
    public class StudentDbContext : DbContext
    {
        public StudentDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Student> Students { get; set; }
    }
}
