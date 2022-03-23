using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace eShopSolution.Data.EF
{
    public class EShopDbContextFactory : IDesignTimeDbContextFactory<EshopDbContext>
    {
        public EshopDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var connectString = configuration.GetConnectionString("eShopSolutionDb");

            var optionBuilder = new DbContextOptionsBuilder<EshopDbContext>();
            optionBuilder.UseSqlServer(connectString);

            return new EshopDbContext(optionBuilder.Options);
        }
    }
}