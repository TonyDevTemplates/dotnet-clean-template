using System.Linq;
using System.Threading.Tasks;
using CleanTemplate.Application.Features.Forecast.Queries;
using CleanTemplate.WebUI.Controllers;

using Microsoft.AspNetCore.Mvc;

namespace CleanTemplate.WebUI.Features.Weather
{
    [Route("api/forecast")]
    public class WeatherForecastController : ApiController
    {
        [HttpGet("{location}")]
        public async Task<ActionResult<IQueryable<WeatherForecastContract>>> Get(string location)
        {
            var action = new GetAllForecastForLocationQuery(User?.Identity?.Name, location);
            var result = await Mediator.Send(action);
            
            return Ok(result);
        }
    }
}
