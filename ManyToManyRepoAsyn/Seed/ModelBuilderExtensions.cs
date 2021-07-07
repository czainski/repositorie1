using ManyToManyCore.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace RelationshipCore3.Seed
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>()
               .HasData(
                  new Student { Id = 1, LastName = "LastName1", Date = new DateTime(2019, 9, 9, 9, 9, 0) },
                  new Student { Id = 2, LastName = "LastName2", Date = new DateTime(2018, 8, 8, 8, 9, 0) },
                  new Student { Id = 3, LastName = "LastName3", Date = new DateTime(2018, 7, 7, 7, 7, 0) },
                  new Student { Id = 4, LastName = "LastName4", Date = new DateTime(2017, 6, 6, 6, 6, 0) },
                  new Student { Id = 5, LastName = "LastName5", Date = new DateTime(2019, 5, 5, 5, 5, 0) }
            );
            //
            modelBuilder.Entity<Project>()
                .HasData(
                   new Project { Id = 1, Name = "Project1", Date = new DateTime(2020, 9, 9, 9, 9, 0)},
                   new Project { Id = 2, Name = "Project2", Date = new DateTime(2019, 9, 9, 9, 9, 0)},
                   new Project { Id = 3, Name = "Project3", Date = new DateTime(2018, 9, 9, 9, 9, 0)}
            );
            //    
            modelBuilder.Entity<StudentProjectJunction>()
                .HasData(
                    new StudentProjectJunction { StudentId = 1, ProjectId = 1 },
                    new StudentProjectJunction { StudentId = 2, ProjectId = 1 },
                    new StudentProjectJunction { StudentId = 3, ProjectId = 2 },
                    new StudentProjectJunction { StudentId = 4, ProjectId = 2 },
                    new StudentProjectJunction { StudentId = 1, ProjectId = 3 },
                    new StudentProjectJunction { StudentId = 3, ProjectId = 3 },
                    new StudentProjectJunction { StudentId = 5, ProjectId = 3 }
             );
        }
    }
}
