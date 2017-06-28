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

        public ParkController(IParkData parkDal)
        {
            this.parkDal = parkDal;
        }


        // GET: Park
        public ActionResult Index()
        {
            return View();
        }
    }
}