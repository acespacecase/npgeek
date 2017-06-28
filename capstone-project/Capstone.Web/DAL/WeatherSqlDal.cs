using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Capstone.Web.Models;
using System.Data.SqlClient;
using Dapper;

namespace Capstone.Web.DAL
{
    public class WeatherSqlDal : IWeatherData
    {
        private const string SQL_GetForecast = "SELECT * FROM weather WHERE parkcode = @parkCode;";
        readonly string connectionString;

        public WeatherSqlDal(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public List<Weather> GetFiveDayForecast(string parkCode)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    List<Weather> forecasts = conn.Query<Weather>(SQL_GetForecast, new { parkCode = parkCode }).ToList();
                    return forecasts;
                }
            }
            catch (SqlException ex)
            {
                throw;
            }
        }
    }
}