using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using PCAssesmentApp.Web.Startup;
namespace PCAssesmentApp.Web.Tests
{
    [DependsOn(
        typeof(PCAssesmentAppWebModule),
        typeof(AbpAspNetCoreTestBaseModule)
        )]
    public class PCAssesmentAppWebTestModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(PCAssesmentAppWebTestModule).GetAssembly());
        }
    }
}