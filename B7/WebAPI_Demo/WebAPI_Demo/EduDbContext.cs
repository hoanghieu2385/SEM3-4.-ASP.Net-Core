using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Security.Claims;
using WebAPI_Demo.Models;

namespace WebAPI_Demo
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
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Student> Students { get; set; }

    }

}
