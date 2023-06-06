using Microsoft.AspNetCore.Mvc;

namespace FourThings.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    private const string _message = "Running the GetWeatherForecast method";
    private static readonly string[] _summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<WeatherForecastController> _logger;

    public WeatherForecastController(ILogger<WeatherForecastController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetWeatherForecast")]
    public IEnumerable<WeatherForecast> Get()
    {
        _logger.Log(LogLevel.Information, _message);
        return Enumerable.Range(1, 5).Select(index => new WeatherForecast
        {
            Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            TemperatureC = GetRandomNumber(-20, 55),
            Summary = _summaries[GetRandomNumber(0, _summaries.Length)]
        })
        .ToArray();
    }

    private static int GetRandomNumber(int start, int end) => Random.Shared.Next(start, end);
}
