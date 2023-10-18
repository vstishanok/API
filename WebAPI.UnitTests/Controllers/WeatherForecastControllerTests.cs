namespace WebAPI.UnitTests.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    using NUnit.Framework;

    using WebAPI.Controllers;

    [TestFixture]
    public class WeatherForecastControllerTests
    {
        [Test]
        public void Get_GetRandomWeatherForecast_ResultIsNotNull()
        {
            var controller = new WeatherForecastController();

            var result = controller.Get();
            var okResult = result as OkObjectResult;

            Assert.IsNotNull(okResult);
        }
    }
}
