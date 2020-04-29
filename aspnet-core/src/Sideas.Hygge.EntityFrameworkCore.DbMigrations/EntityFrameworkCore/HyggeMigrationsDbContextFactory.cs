using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Sideas.Hygge.EntityFrameworkCore
{
    /* This class is needed for EF Core console commands
     * (like Add-Migration and Update-Database commands) */
    public class HyggeMigrationsDbContextFactory : IDesignTimeDbContextFactory<HyggeMigrationsDbContext>
    {
        public HyggeMigrationsDbContext CreateDbContext(string[] args)
        {
            HyggeEfCoreEntityExtensionMappings.Configure();

            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<HyggeMigrationsDbContext>()
                .UseSqlServer(configuration.GetConnectionString("Default"));

            return new HyggeMigrationsDbContext(builder.Options);
        }

        private static IConfigurationRoot BuildConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false);

            return builder.Build();
        }
    }
}
