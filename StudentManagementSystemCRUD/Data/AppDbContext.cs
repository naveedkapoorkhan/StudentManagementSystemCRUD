using Microsoft.EntityFrameworkCore;
using StudentManagementSystemCRUD.Models;

namespace StudentManagementSystemCRUD.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        //adding student table class AppDbContext
        public DbSet<Student> Students { get; set; }  // Table Students it defines a table in EF. EF will handle table creation when you apply migrations.
    }
}
//DbContext is the bridge between your C# classes and the database:
//DbContext = bridge between C# and database.

//DbSet < Student > = represents the Students table.