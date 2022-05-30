using Abp.Modules;
using Abp.Reflection.Extensions;
using PCAssesmentApp.Localization;

namespace PCAssesmentApp
{
    public class PCAssesmentAppCoreModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Auditing.IsEnabledForAnonymousUsers = true;

            PCAssesmentAppLocalizationConfigurer.Configure(Configuration.Localization);
            
            Configuration.Settings.SettingEncryptionConfiguration.DefaultPassPhrase = PCAssesmentAppConsts.DefaultPassPhrase;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(PCAssesmentAppCoreModule).GetAssembly());
        }
    }
}