using Microsoft.AspNetCore.Mvc;

namespace PCAssesmentApp.Web.Controllers
{
    public class HomeController : PCAssesmentAppControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}