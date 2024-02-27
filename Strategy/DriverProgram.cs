using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class DriverProgram
    {
       
        public static void Main(string[] args)
        {
            ITravel travel = new CarTraveller();
            TravelStrategy travelStrategy = new TravelStrategy(travel);
            travelStrategy.GetTravelStrategy();

            travelStrategy.SetTravelStrategy(new RickshawTraveller());
            travelStrategy.GetTravelStrategy();
        }
    }
}
