using Abp.AspNetCore.Mvc.Views;

namespace PCAssesmentApp.Web.Views
{
    public abstract class PCAssesmentAppRazorPage<TModel> : AbpRazorPage<TModel>
    {
        protected PCAssesmentAppRazorPage()
        {
            LocalizationSourceName = PCAssesmentAppConsts.LocalizationSourceName;
        }
    }
}
