using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capstone.Web.DAL;
using Capstone.Web.Models;

namespace Capstone.Web.Tests.TestDouble
{
     class ParkDoubleDal : IParkData
    {
        public List<Park> GetAllParks()
        {
            return new List<Park>()
            {
                {
                    new Park(){
                        ParkCode = "CVNP",
                        Acreage = 13,
                        ParkName = "cvnp",
                        ParkDescription = "...",
                        AnnualVisitorCount = 12,
                        NumberOfAnimalSpecies = 1,
                        NumberOfCampsites = 100,
                        Climate = "trees",
                        EntryFee = 2000,
                        InspirationalQuote = "come see the trees!",
                        InspirationalQuoteSource = "anon",
                        ElevationInFeet = 2
                    }
                }
            };
        }

        public Park GetPark(string parkCode)
        {
            return new Park()
            {
                ParkCode = "CVNP",
                Acreage = 13,
                ParkName = "cvnp",
                ParkDescription = "...",
                AnnualVisitorCount = 12,
                NumberOfAnimalSpecies = 1,
                NumberOfCampsites = 100,
                Climate = "trees",
                EntryFee = 2000,
                InspirationalQuote = "come see the trees!",
                InspirationalQuoteSource = "anon",
                ElevationInFeet = 2
            };
        }
    }
}
