using Microsoft.EntityFrameworkCore;
using MVCProject.DataAccessLayer.Models;

namespace MVCProject.DataAccessLayer
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options) 
        {
            
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<TeacherStudent> TeachersStudents { get;set; }
    }
}
