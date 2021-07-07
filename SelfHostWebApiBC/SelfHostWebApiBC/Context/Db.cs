using System.Data.Entity;
using SelfHostWebApiBC.Models;
using SelfHostWebApiBC.Seed;

namespace SelfHostWebApiBC.Context
{
    public class Db : DbContext
    {
       public Db(string location = "localdb") : base(location)
        {
            Database.SetInitializer<Db>(new DbInitializer());
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
             modelBuilder.Entity<Employee>()
                .HasIndex(e => new { e.FirstName, e.LastName });
    
            modelBuilder.Entity<Employee>()
                .HasRequired<Company>(c => c.Company)
                .WithMany(e => e.Employees)
                .HasForeignKey<long>(c => c.CompanyId);
        }
        public DbSet<Employee>   Employees { get; set; }
        public DbSet<Company>   Companys { get; set; }
    }
}
