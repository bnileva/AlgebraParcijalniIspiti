using aspnet_core_unit_1A.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Xunit.Sdk;

namespace UnitTesting
{
    public class HomeControllerTests
    {
        public static ILogger<HomeController> logger;

        [Fact]
        public void HomeController_CheckCountValueTest_500()
        {
            var controller = new HomeController(logger);

            Action result = () => controller.CheckCountValue(500);
            
            Assert.Throws<Exception>(result);
        }

        [Fact]
        public void HomeController_CheckCountValueTest_2()
        {

            var controller = new HomeController(logger);

            var result = controller.CheckCountValue(2) as ViewResult;

            Assert.IsType<ViewResult>(result);
            Assert.Equal(2, result.Model);

        }
    }
}
