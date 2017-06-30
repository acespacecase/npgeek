using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capstone.Web.DAL;
using Capstone.Web.Models;

namespace Capstone.Web.Tests.TestDouble
{
    class WeatherDoubleDal : IWeatherData
    {
        public List<Weather> GetFiveDayForecast(string parkCode)
        {
            return new List<Weather>()
            {
                new Weather()
                {
                    ParkCode = "CVNP",
                    FiveDayForecastValue = 1,
                    Low = 38,
                    High = 62,
                    Forecast = "rain"
                }
            };
        }
    }
}
