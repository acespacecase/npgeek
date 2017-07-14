using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Capstone.Web.Models
{
    public class ParkSurveyViewModel
    {
        public List<Park> Parks { get; set; }
        //public List<Survey> Surveys { get; set; }

        public Dictionary<string, int> SurveysGroupedByPark { get; set; }
    }
}