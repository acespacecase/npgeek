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

        public Dictionary<string, int> GetAllSurveys()
        {
            return new Dictionary<string, int>()
            {
                { "CVNP", 2 }
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
