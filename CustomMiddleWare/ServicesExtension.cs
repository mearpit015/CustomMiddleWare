using CustomMiddleWare.Services;

namespace CustomMiddleWare
{
    public static class ServicesExtension
    {
        public static void AddServices(this IServiceCollection serviceDescriptors)
        {
            serviceDescriptors.AddScoped<IGetWeatherForecast, GetWeatherForecast>();
        }
    }
}
