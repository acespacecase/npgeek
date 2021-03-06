﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Capstone.Web.Models;
using System.Data.SqlClient;
using Dapper;

namespace Capstone.Web.DAL
{
    public class SurveySqlDal : ISurveyData
    {
        //private const string SQL_GetAllSurveys = "SELECT survey_result.* FROM survey_result LEFT JOIN park ON survey_result.parkCode = park.parkCode ORDER BY park.parkName;";
        private const string SQL_GetAllSurveys = "SELECT survey_result.parkCode, Count(*) as surveyCount FROM survey_result GROUP BY parkCode ORDER BY surveyCount desc, parkCode asc;";
        private const string SQL_GetSurvey = "SELECT * FROM survey_result WHERE surveyId = @id;";
        private const string SQL_AddSurvey = "INSERT INTO survey_result VALUES(@parkCode, @emailAddress, @state, @activityLevel);";
        readonly string connectionString;

        public SurveySqlDal(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void AddSurvey(Survey s)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    conn.Execute(SQL_AddSurvey, new { parkCode = s.ParkCode, emailAddress = s.EmailAddress, state = s.State, activityLevel = s.ActivityLevel });
                }
            }
            catch (SqlException ex)
            {
                throw;
            }
        }

        public Dictionary<string, int> GetAllSurveys()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    Dictionary<string, int> SurveysGroupedByPark = new Dictionary<string, int>();

                    SqlCommand cmd = new SqlCommand(SQL_GetAllSurveys, conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while(reader.Read())
                    {
                        SurveysGroupedByPark.Add(reader["parkCode"].ToString(), (int)reader["surveyCount"]);
                    }

                    return SurveysGroupedByPark;

                    //List<Survey> allSurveys = conn.Query<Survey>(SQL_GetAllSurveys).ToList();
                    //return allSurveys;
                }
            }
            catch(SqlException ex)
            {
                throw;
            }
        }

        public Survey GetSurvey(int id)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    Survey singleSurvey = conn.QueryFirstOrDefault<Survey>(SQL_GetSurvey, new { surveyId = id });
                    return singleSurvey;
                }
            }
            catch (SqlException ex)
            {
                throw;
            }
        }
    }
}