using Microsoft.AspNetCore.Mvc;
using testposho.clases;

namespace testposho.Controllers
{
    [ApiController]
    
    public class WeatherForecastController : Controller 
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [Route("watherforecast")]
        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }
        [Route("posholoco")]
        [HttpGet]
        public async Task<CUARZO> Getcuarzo()
        {
            try
            {
                var amatista = new CUARZO();
                amatista.energia = "morado";
                if (amatista.brillo > 80)
                {
                    amatista.esreal = false;
                }

                return amatista;
            }
            catch (Exception)
            {

                throw;
            }
            
        }
    }
}
