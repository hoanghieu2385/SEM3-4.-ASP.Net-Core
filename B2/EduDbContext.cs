using Microsoft.EntityFrameworkCore;
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
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Class>();
            modelBuilder.Entity<Student>();
        }

        public DbSet<Class> classes { get; set; }
        public DbSet<Student> students { get; set; }
    }
}
