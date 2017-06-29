using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Capstone.Web.Models
{
    public class Weather
    {
        public string ParkCode { get; set; }
        public int FiveDayForecastValue { get; set; }
        public int Low { get; set; }
        public int High { get; set; }
        public string Forecast { get; set; }

        public string ImageName
        {
            get
            {
                if (this.Forecast == "partly cloudy")
                {
                    return "wi-day-cloudy";
                }
                else if (Forecast == "sunny")
                {
                    return "wi-day-sunny";
                }
                else if (Forecast == "thunderstorms")
                {
                    return "wi-thunderstorm";
                }
                else if (Forecast == "snow")
                {
                    return "wi-snow";
                }
                else if (Forecast == "cloudy")
                {
                    return "wi-cloudy";
                }
                else if (Forecast == "rain")
                {
                    return "wi-rain";
                }

                return "wi-alien";
            }
        }

        public string ForecastRecommendation
        {
            get
            {
                string recommendation = "";

                if (High > 75)
                {
                    recommendation += "It's a hot one! Bring an extra gallon of water. ";
                }

                if (High - Low > 20)
                {
                    recommendation += "You better wear breathable layers. ";
                }

                if (Low < 20)
                {
                    recommendation += "Be wary of low temperatures: It's dangerous to be exposed to frigid temperatures. ";
                }

                if (this.Forecast == "snow")
                {
                    recommendation += "Better bring some snowshoes! ";
                }
                else if (this.Forecast == "rain")
                {
                    recommendation += "Make sure to pack your rain gear and wear waterproof shoes. ";
                }
                else if (this.Forecast == "thunderstorms")
                {
                    recommendation += "Please seek shelter and avoid hiking on exposed ridges. ";
                }
                else if (this.Forecast == "sunny")
                {
                    recommendation += "Pack sunblock! ";
                }

                return recommendation.Trim();
            }
        }

        public int HighC
        {
            get
            {
                return (int)(Math.Round(((this.High - 32.00) * (5.00 / 9.00))));
            }
        }

        public int LowC
        {
            get
            {
                return (int)(Math.Round(((this.Low - 32.00) * (5.00 / 9.00))));
            }
        }
    }
}