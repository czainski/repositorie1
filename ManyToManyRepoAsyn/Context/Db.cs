using ManyToManyCore.Models;
using Microsoft.EntityFrameworkCore;
using RelationshipCore3.Seed;

namespace BC.Context
{
    public class Db : DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StudentProjectJunction>()
                .HasKey(pt => new { pt.StudentId, pt.ProjectId });

            modelBuilder.Entity<StudentProjectJunction>()
                .HasOne(pt => pt.Student)
                .WithMany(p => p.StudentProjectJunction)
                .HasForeignKey(pt => pt.StudentId);

            modelBuilder.Entity<StudentProjectJunction>()
                .HasOne(pt => pt.Project)
                .WithMany(t => t.StudentProjectJunction)
                .HasForeignKey(pt => pt.ProjectId);
  
            modelBuilder.Seed();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Server=(localdb)\MSSQLLocalDB;Database=_Test;Integrated Security=True");
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Project>  Projects  { get; set;  }
        
    }//


    
}



