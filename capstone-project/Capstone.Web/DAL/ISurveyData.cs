using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Capstone.Web.Models;

namespace Capstone.Web.DAL
{
    public interface ISurveyData
    {
        List<Survey> GetAllSurveys();
        Survey GetSurvey(int id);
        void EditSurvey(Survey s);
        void AddSurvey(Survey s);
    }
}