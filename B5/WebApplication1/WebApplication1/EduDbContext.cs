using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using WebApplication1.Models;

namespace WebApplication1
{
    public class EduDbContext : DbContext
    {
        public EduDbContext() : base()
        {

        }

        public EduDbContext(DbContextOptions<EduDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Class>();
            modelBuilder.Entity<Student>();
            modelBuilder.Entity<StudentReport>().HasNoKey();
        }
        
        public DbSet<Class> Classes { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Courses> Courses { get; set; }
        public DbSet<StudentCourse> StudentCourses { get;set; }
        public DbSet<StudentReport> studentReports { get; set; }

    }
}
