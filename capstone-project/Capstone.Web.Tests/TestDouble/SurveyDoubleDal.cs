using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capstone.Web.DAL;
using Capstone.Web.Models;

namespace Capstone.Web.Tests.TestDouble
{
    public class SurveyDoubleDal : ISurveyData
    {
        public void AddSurvey(Survey s)
        {
            return;
        }

        public List<Survey> GetAllSurveys()
        {
            return new List<Survey>()
            {
                new Survey()
                {
                    SurveyId = 1,
                    ParkCode = "CVNP",
                    EmailAddress = "email@email.com",
                    State = "Ohio",
                    ActivityLevel = "Active"
                }
            };
        }

        public Survey GetSurvey(int id)
        {
            return new Survey()
            {
                SurveyId = 1,
                ParkCode = "CVNP",
                EmailAddress = "email@email.com",
                State = "Ohio",
                ActivityLevel = "Active"
            };
        }
    }
}
