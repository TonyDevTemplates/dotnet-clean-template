using System;
using System.Collections.Generic;
using CleanTemplate.Domain.Common;
using CleanTemplate.Domain.Entities.Forecasts;

namespace CleanTemplate.Domain.Entities.Locations
{
    public class Location : IEntity<Guid>
    {
        public Location()
        {
            Forecasts = new List<WeatherForecast>();
        }

        public Guid Id { get; set; }
        
        public string City { get; set; }

        public IList<WeatherForecast> Forecasts { get; }
    }
}
