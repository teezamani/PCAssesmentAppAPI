using System.Threading.Tasks;
using PCAssesmentApp.Web.Controllers;
using Shouldly;
using Xunit;

namespace PCAssesmentApp.Web.Tests.Controllers
{
    public class HomeController_Tests: PCAssesmentAppWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}
