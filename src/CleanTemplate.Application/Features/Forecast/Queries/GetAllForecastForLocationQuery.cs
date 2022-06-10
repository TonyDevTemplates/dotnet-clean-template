using System.Linq;
using System.Threading;
using System.Threading.Tasks;

using CleanTemplate.Application.Common;
using CleanTemplate.Domain.Entities.Forecasts;

using MediatR;

namespace CleanTemplate.Application.Features.Forecast.Queries
{
    public class GetAllForecastForLocationQuery : BaseCqrsRequest<IQueryable<WeatherForecast>>
    {
        public GetAllForecastForLocationQuery(string appUser, string location)
            : base(appUser)
        {
            Location = location;
        }

        public string Location { get; }
    }

    internal class GetAllForecastForLocationQueryHandler
        : IRequestHandler<GetAllForecastForLocationQuery, IQueryable<WeatherForecast>>
    {

        public GetAllForecastForLocationQueryHandler()
        {
        }

        public Task<IQueryable<WeatherForecast>> Handle(GetAllForecastForLocationQuery request, CancellationToken cancellationToken)
        {

            return Task.FromResult<IQueryable<WeatherForecast>>(null);
        }
    }
}
