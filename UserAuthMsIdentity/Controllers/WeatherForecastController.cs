using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Web.Resource;
using Microsoft.Graph;

namespace UserAuthMsIdentity.Controllers
{
    [Authorize]
    [ApiController]
    [RequiredScope(RequiredScopesConfigurationKey = "AzureAd:Scopes")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly GraphServiceClient _graphServiceClient;
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, GraphServiceClient graphServiceClient)
        {
            _logger = logger;
            _graphServiceClient = graphServiceClient;
        }

        [HttpGet]
        [Route("[controller]/[action]")]
        public async Task<IEnumerable<WeatherForecast>> GetWeatherForecast()
        {
            var user = await _graphServiceClient.Me.Request().GetAsync();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }

        [HttpGet]
        [Route("hello")]
        public async Task<IActionResult> Hello()
        {
            var user = await _graphServiceClient.Me.Request().GetAsync();
            return Ok($"Hello {user.DisplayName} from {user.Country}");
        }
    }
}
