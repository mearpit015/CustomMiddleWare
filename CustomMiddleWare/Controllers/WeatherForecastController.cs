using CustomMiddleWare.Services;
using Microsoft.AspNetCore.Mvc;

namespace CustomMiddleWare.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
       

        private readonly ILogger<WeatherForecastController> _logger;
        private readonly IGetWeatherForecast _weatherForecast;

        public WeatherForecastController(ILogger<WeatherForecastController> logger,
            IGetWeatherForecast weatherForecast)
        {
            _logger = logger;
            _weatherForecast = weatherForecast;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            return _weatherForecast.Get();
        }

        
    }
}