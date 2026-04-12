using Colegio.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Colegio.Controllers
{
    [ApiController]
    [Route("")]
    public class WeatherForecastController : ControllerBase
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

        [HttpGet(Name = "Alumnos/{id}")]
        public IEnumerable<WeatherForecast> Get([FromQuery] string id)
        {
            Console.WriteLine(id);
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }
        [HttpPost("CrearUsuario")]
        public String CrearUsuario([FromBody] Alumno alumno)
        {
            return "usuarioCreado"+ alumno.Apellido+ " "+ alumno.Nombre + " " + alumno.Dni;
        }
        [HttpPost("DevolverUsuario")]
        public Alumno DevolverUsuario([FromBody] Alumno alumno)
        {
            return alumno;
        }
    }
}
