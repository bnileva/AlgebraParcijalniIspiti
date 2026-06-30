using aspnet_core_unit_1A.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace UnitTesting
{
    public class HomeControllerTests
    {
        public static ILogger<HomeController> logger;

        [Fact]
        public void HomeController_CheckCountValueTest_500()
        {
            var controller = new HomeController(logger);

            var result = controller.CheckCountValue(500);
            //Assert.IsType<Exception>(controller.CheckCountValue(500));
            //Assert.Throws(controller.CheckCountValue(500));
            //Assert.ThrowsAny<Exception>(controller.CheckCountValue(500));
            //Assert.Fail();
        }

        [Fact]
        public void HomeController_CheckCountValueTest_2()
        {

            var controller = new HomeController(logger);

            var result = controller.CheckCountValue(2);

            Assert.IsType<ViewResult>(result);

        }
    }
}
