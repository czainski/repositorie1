using System;
using BC.Context;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
//
//
namespace RelationshipManyToManyCore3
{
    static public class Database
    {
        //Database.Delete();
        static public void Delete()
        {
            Console.WriteLine(nameof(Delete) + " database!");
            using (var context = new Db())
            {
                context.Database.EnsureDeleted();
            }
        }
        //Database.Create();
        static public void Create()
        {
            Console.WriteLine(nameof(Create) + " database!");
            using (var context = new Db())
            {
                if (context.Database.EnsureCreated())
                {
                    Console.WriteLine($"They have created  database. ");
                }
                else
                {
                    Console.WriteLine($"They have NOT created database. ");
                };
            }
        }//
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Database.Delete();
            Database.Create();
            CreateHostBuilder(args).Build().Run();
        }
        //
        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
