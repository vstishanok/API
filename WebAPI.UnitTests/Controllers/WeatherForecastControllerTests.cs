namespace WebAPI.UnitTests.Controllers
{
    using NUnit.Framework;

    using WebAPI.Controllers;

    [TestFixture]
    public class WeatherForecastControllerTests
    {
        private WeatherForecastController controller;

        [SetUp]
        public void Setup()
        {
            controller = new WeatherForecastController();
        }

        [Test]
        public void Get_GetRandomWeatherForecast_ResultIsNotNull()
        {
            var weatherForecast = controller.Get();

            Assert.IsNotNull(weatherForecast);
        }

        [Test]
        public void Get_GetRandomWeatherForecast_ResultIsNotEmpty()
        {
            var weatherForecast = controller.Get();

            Assert.IsNotEmpty(weatherForecast);
        }
    }
}