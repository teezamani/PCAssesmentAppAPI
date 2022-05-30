using Abp.AspNetCore.Mvc.Controllers;

namespace PCAssesmentApp.Web.Controllers
{
    public abstract class PCAssesmentAppControllerBase: AbpController
    {
        protected PCAssesmentAppControllerBase()
        {
            LocalizationSourceName = PCAssesmentAppConsts.LocalizationSourceName;
        }
    }
}