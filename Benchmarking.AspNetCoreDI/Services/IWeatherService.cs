using System.Collections.Generic;

namespace Benchmarking.AspNetCoreDI.Services
{
    public interface IWeatherService
    {
        IEnumerable<WeatherForecast> GetWeatherForecast();
    }
}