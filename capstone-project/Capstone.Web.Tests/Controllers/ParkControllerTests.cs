using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Capstone.Web.Controllers;
using Capstone.Web.Tests.TestDouble;
using System.Web.Mvc;
using System.Collections.Generic;
using Capstone.Web.Models;

namespace Capstone.Web.Tests.Controllers
{
    [TestClass]
    public class ParkControllerTests
    {
        [TestMethod]
        public void ParkController_ReturnsIndex()
        {
            WeatherDoubleDal weatherDouble = new WeatherDoubleDal();
            ParkDoubleDal parkDouble = new ParkDoubleDal();
            ParkController parkController = new ParkController(parkDouble, weatherDouble);

            ViewResult result = parkController.Index() as ViewResult;

            Assert.IsNotNull(result);
            Assert.AreEqual("Index", result.ViewName);
            Assert.IsNotNull(result.Model);
            Assert.IsTrue(result.Model is List<Park>);
        }

        //[TestMethod]
        //public void ReturnsDetail()
        //{
        //    WeatherDoubleDal weatherDouble = new WeatherDoubleDal();
        //    ParkDoubleDal parkDouble = new ParkDoubleDal();
        //    ParkController parkController = new ParkController(parkDouble, weatherDouble);

        //    ViewResult result = parkController.Detail("CVNP") as ViewResult;

        //    Assert.IsNotNull(result);
        //    Assert.AreEqual("Detail", result.ViewName);
        //    Assert.IsNotNull(result.Model);
        //    Assert.IsTrue(result.Model is Park);
        //}
    }
}
