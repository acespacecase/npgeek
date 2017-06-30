using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Capstone.Web.Tests.TestDouble;
using Capstone.Web.Controllers;
using System.Web.Mvc;
using System.Collections.Generic;
using Capstone.Web.Models;

namespace Capstone.Web.Tests.Controllers
{
    [TestClass]
    public class SurveyControllerTests
    {
        [TestMethod]
        public void SurveyController_ReturnsIndex()
        {
            SurveyDoubleDal surveyDouble = new SurveyDoubleDal();
            ParkDoubleDal parkDouble = new ParkDoubleDal();
            SurveyController surveyController = new SurveyController(parkDouble, surveyDouble);

            ViewResult result = surveyController.Index() as ViewResult;

            Assert.IsNotNull(result);
            Assert.AreEqual("Index", result.ViewName);
            Assert.IsNotNull(result.Model);
            Assert.IsTrue(result.Model is ParkSurveyViewModel);
        }

        [TestMethod]
        public void SurveyController_AddSurvey()
        {
            SurveyDoubleDal surveyDouble = new SurveyDoubleDal();
            ParkDoubleDal parkDouble = new ParkDoubleDal();
            SurveyController surveyController = new SurveyController(parkDouble, surveyDouble);

            ViewResult result = surveyController.Add() as ViewResult;

            Assert.IsNotNull(result);
            Assert.AreEqual("Add", result.ViewName);
            Assert.IsNotNull(result.Model);
            Assert.IsTrue(result.Model is Survey);
        }
    }
}
