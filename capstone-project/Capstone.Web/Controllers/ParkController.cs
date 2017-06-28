using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Capstone.Web.Models;
using Capstone.Web.DAL;

namespace Capstone.Web.Controllers
{
    public class ParkController : Controller
    {
        private IParkData parkDal;
        private IWeatherData weatherDal;

        public ParkController(IParkData parkDal, IWeatherData weatherDal)
        {
            this.parkDal = parkDal;
            this.weatherDal = weatherDal;
        }

        // GET: Park
        public ActionResult Index()
        {
            List<Park> model = parkDal.GetAllParks();
            return View("Index", model);
        }

        public ActionResult Detail(string parkCode)
        {
            ParkWeatherViewModel model = new ParkWeatherViewModel()
            {
                Park = parkDal.GetPark(parkCode),
                Forecast = weatherDal.GetFiveDayForecast(parkCode)
            };

            if(model == null)
            {
                return HttpNotFound();
            }
            else
            {
                return View("Detail", model);
            }
        }
    }
}