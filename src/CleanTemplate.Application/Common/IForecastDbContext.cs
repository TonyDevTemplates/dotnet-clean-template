using System.Threading;
using System.Threading.Tasks;

using CleanTemplate.Domain.Entities.Forecasts;
using CleanTemplate.Domain.Entities.Locations;

using Microsoft.EntityFrameworkCore;

namespace CleanTemplate.Application.Common
{
    public interface IForecastDbContext
    {
        DbSet<WeatherForecast> WeatherForecasts { get; set; }

        DbSet<Location> Locations { get; set; }

        Task<int> SaveChangesAsync(CancellationToken token);
    }
}