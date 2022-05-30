using Abp.Application.Services;

namespace PCAssesmentApp
{
    /// <summary>
    /// Derive your application services from this class.
    /// </summary>
    public abstract class PCAssesmentAppAppServiceBase : ApplicationService
    {
        protected PCAssesmentAppAppServiceBase()
        {
            LocalizationSourceName = PCAssesmentAppConsts.LocalizationSourceName;
        }
    }
}