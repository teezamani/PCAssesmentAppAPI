using Abp.EntityFrameworkCore;
using Abp.Modules;
using Abp.Reflection.Extensions;

namespace PCAssesmentApp.EntityFrameworkCore
{
    [DependsOn(
        typeof(PCAssesmentAppCoreModule), 
        typeof(AbpEntityFrameworkCoreModule))]
    public class PCAssesmentAppEntityFrameworkCoreModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(PCAssesmentAppEntityFrameworkCoreModule).GetAssembly());
        }
    }
}