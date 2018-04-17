using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningInterfaceAndAbstractClassV0._5
{
    class Mars : PlanetMission
    {
        public Mars()
        {
            SetMissionInfo(75000000, 10000, 25000); //It's similar to interface, if we dont use this method to set up values. We gonna get error.
        }
        public override void SetMissionInfo(int milesToPlanet, int rocketFuelPerMile, long rocketSpeedMPH)
        {
            this.MilesToPlanet = milesToPlanet;
            this.RocketFuelPerMile = rocketFuelPerMile;
            this.RocketSpeedMPH = rocketSpeedMPH;

        }
    }
}
