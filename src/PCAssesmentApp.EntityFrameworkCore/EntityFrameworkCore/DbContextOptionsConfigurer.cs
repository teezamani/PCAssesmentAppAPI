using Microsoft.EntityFrameworkCore;

namespace PCAssesmentApp.EntityFrameworkCore
{
    public static class DbContextOptionsConfigurer
    {
        public static void Configure(
            DbContextOptionsBuilder<PCAssesmentAppDbContext> dbContextOptions, 
            string connectionString
            )
        {
            /* This is the single point to configure DbContextOptions for PCAssesmentAppDbContext */
            dbContextOptions.UseNpgsql(connectionString);
        }
    }
}
