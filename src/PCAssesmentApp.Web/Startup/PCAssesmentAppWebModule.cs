using Abp.AspNetCore;
using Abp.AspNetCore.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using PCAssesmentApp.Configuration;
using PCAssesmentApp.EntityFrameworkCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.ApplicationParts;
using Microsoft.Extensions.Configuration;

namespace PCAssesmentApp.Web.Startup
{
    [DependsOn(
        typeof(PCAssesmentAppApplicationModule), 
        typeof(PCAssesmentAppEntityFrameworkCoreModule), 
        typeof(AbpAspNetCoreModule))]
    public class PCAssesmentAppWebModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public PCAssesmentAppWebModule(IWebHostEnvironment env)
        {
            _appConfiguration = AppConfigurations.Get(env.ContentRootPath, env.EnvironmentName);
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(PCAssesmentAppConsts.ConnectionStringName);

            Configuration.Navigation.Providers.Add<PCAssesmentAppNavigationProvider>();

            Configuration.Modules.AbpAspNetCore()
                .CreateControllersForAppServices(
                    typeof(PCAssesmentAppApplicationModule).GetAssembly()
                );
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(PCAssesmentAppWebModule).GetAssembly());
        }

        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(PCAssesmentAppWebModule).Assembly);
        }
    }
}
