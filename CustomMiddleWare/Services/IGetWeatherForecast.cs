namespace CustomMiddleWare.Services
{
    public interface IGetWeatherForecast
    {
        IEnumerable<WeatherForecast> Get();
    }
}
