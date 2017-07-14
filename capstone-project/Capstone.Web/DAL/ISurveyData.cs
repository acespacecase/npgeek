using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Capstone.Web.Models;

namespace Capstone.Web.DAL
{
    public interface ISurveyData
    {
        Dictionary<string, int> GetAllSurveys();
        Survey GetSurvey(int id);
        void AddSurvey(Survey s);
    }
}