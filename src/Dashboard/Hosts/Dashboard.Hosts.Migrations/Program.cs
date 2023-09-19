using Microsoft.Extensions.Configuration;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Dashboard.Hosts.Migrations;

namespace Dashboard.Hosts.Migration
{
    public class Program
    {
        static void Main(string[] args)
        {
            //var builder = new ConfigurationBuilder();
            //builder.SetBasePath(Directory.GetCurrentDirectory());
            string connectionString = "";

            var optionsBuilder = new DbContextOptionsBuilder<MigrationDbContext>();
            var options = optionsBuilder.UseNpgsql(connectionString).Options;

            using (MigrationDbContext db = new MigrationDbContext(options))
            {
                db.Database.Migrate();
            }
        
        }

    }
}