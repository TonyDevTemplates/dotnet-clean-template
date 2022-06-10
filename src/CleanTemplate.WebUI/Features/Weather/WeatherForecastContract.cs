using System;

namespace CleanTemplate.WebUI.Features.Weather
{
    public class WeatherForecastContract
    {
        public Guid Id { get; set; }
        public int Temperature { get; set; }
        public string Wind { get; set; }
        public string Clouds { get; set; }
        public DateTime ForecastDate { get; set; }
        public string Summary { get; set; }

        public string LocationName { get; set; }
    }
}
