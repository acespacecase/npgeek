using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Capstone.Web.DAL;
using Capstone.Web.Models;

namespace Capstone.Web.Controllers
{
    public class SurveyController : Controller
    {
        private IParkData parkDal;
        private ISurveyData surveyDal;

        public SurveyController(IParkData parkDal, ISurveyData surveyDal)
        {
            this.parkDal = parkDal;
            this.surveyDal = surveyDal;
        }

        // GET: Survey
        public ActionResult Index()
        {
            ParkSurveyViewModel model = new ParkSurveyViewModel()
            {
                Parks = parkDal.GetAllParks(),
                //Surveys = surveyDal.GetAllSurveys(),
                SurveysGroupedByPark = surveyDal.GetAllSurveys()
            };

            return View("Index", model);
        }

        public ActionResult Add()
        {
            List<Park> allParks = parkDal.GetAllParks();

            Survey model = new Survey()
            {
                AllParks = ConvertListToSelectList(allParks)
            };

            return View("Add", model);
        }

        private List<SelectListItem> ConvertListToSelectList(List<Park> dropDownListItems)
        {
            List<SelectListItem> dropDownList = new List<SelectListItem>();

            foreach (Park p in dropDownListItems)
            {
                SelectListItem choice = new SelectListItem() { Text = p.ParkName, Value = p.ParkCode };
                dropDownList.Add(choice);
            }
            return dropDownList;
        }

        [HttpPost]
        public ActionResult Add(Survey newSurvey)
        {
            surveyDal.AddSurvey(newSurvey);

            return RedirectToAction("Index", "Survey");
        }

    }
}