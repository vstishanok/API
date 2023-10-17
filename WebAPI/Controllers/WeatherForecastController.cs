namespace WebAPI.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries =
            {
                "YES"
            };

        [HttpGet]
        public string Get()
        {
            var randomIndex = new Random().Next(0, Summaries.Length);

            return Summaries[randomIndex];
        }
    }
}
