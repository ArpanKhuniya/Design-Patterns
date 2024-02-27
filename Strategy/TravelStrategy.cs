using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class TravelStrategy
    {
        private ITravel _iTravel;

        public TravelStrategy(ITravel iTravel) 
        {
            _iTravel = iTravel;
        }

        public void SetTravelStrategy(ITravel iTravel)
        {
            _iTravel = iTravel;
            Console.WriteLine("Travel Strategy Changed.");
        }

        public void GetTravelStrategy()
        {
            _iTravel.TravelToAirport();
        }
    }
}
