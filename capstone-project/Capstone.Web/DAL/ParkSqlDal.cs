using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Capstone.Web.Models;
using System.Data.SqlClient;
using Dapper;

namespace Capstone.Web.DAL
{
    public class ParkSqlDal : IParkData
    {
        private const string SQL_GetAllParks = "SELECT * FROM park;";
        readonly string connectionString;

        public ParkSqlDal(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public List<Park> GetAllParks()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    List<Park> allParks = conn.Query<Park>(SQL_GetAllParks).ToList();
                    return allParks;
                }
            }
            catch (SqlException ex)
            {
                throw;
            }
        }

        public Park GetPark(string parkCode)
        {
            try
            {
                using(SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    Park singlePark = conn.Query<Park>("SELECT * FROM park WHERE parkCode = @parkCode;", new { parkCode = parkCode }).First();
                    return singlePark;
                }
            }
            catch(SqlException ex)
            {
                throw;
            }
        }
    }
}