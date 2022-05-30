using PCAssesmentApp.Configuration;
using PCAssesmentApp.Web;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace PCAssesmentApp.EntityFrameworkCore
{
    /* This class is needed to run EF Core PMC commands. Not used anywhere else */
    public class PCAssesmentAppDbContextFactory : IDesignTimeDbContextFactory<PCAssesmentAppDbContext>
    {
        public PCAssesmentAppDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<PCAssesmentAppDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            DbContextOptionsConfigurer.Configure(
                builder,
                configuration.GetConnectionString(PCAssesmentAppConsts.ConnectionStringName)
            );

            return new PCAssesmentAppDbContext(builder.Options);
        }
    }
}