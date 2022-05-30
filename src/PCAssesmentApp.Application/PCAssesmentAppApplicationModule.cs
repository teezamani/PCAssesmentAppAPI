using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;

namespace PCAssesmentApp
{
    [DependsOn(
        typeof(PCAssesmentAppCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class PCAssesmentAppApplicationModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(PCAssesmentAppApplicationModule).GetAssembly());
        }
    }
}