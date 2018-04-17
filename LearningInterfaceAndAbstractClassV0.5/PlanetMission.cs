using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningInterfaceAndAbstractClassV0._5
{
    abstract class PlanetMission //If we decalre class as abstract one, we will not be able to create his object.
    {
        public long RocketFuelPerMile;
        public long RocketSpeedMPH;
        public int MilesToPlanet;

        public long UnitsOfFuelNeeded()
        {
            return MilesToPlanet * RocketFuelPerMile;
        }
        public int TimeNeeded()
        {
            return MilesToPlanet / (int)RocketSpeedMPH;
        }
        public string FuelNeeded()
        {
            return "Będziesz potrzebował "
                + UnitsOfFuelNeeded()
                + " jednostek paliwa, aby się tam dostać. Zajmie Ci to "
                + TimeNeeded() + " godzin.";
        }
    }
}
