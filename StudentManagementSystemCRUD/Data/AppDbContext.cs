using Microsoft.EntityFrameworkCore;
using StudentManagementSystemCRUD.Models;

namespace StudentManagement.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Student> Students { get; set; }  // Table Students
    }
}

//DbContext = bridge between C# and database.

//DbSet < Student > = represents the Students table.