using Abp.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PCAssesmentApp.Models;

namespace PCAssesmentApp.EntityFrameworkCore
{
    public class PCAssesmentAppDbContext : AbpDbContext
    {
        //Add DbSet properties for your entities...
        public DbSet<User> Users { get; set; }
        public PCAssesmentAppDbContext(DbContextOptions<PCAssesmentAppDbContext> options) 
            : base(options)
        {

        }
    }
}
