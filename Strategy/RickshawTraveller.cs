using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class RickshawTraveller : ITravel
    {
        public void TravelToAirport()
        {
            Console.WriteLine("Travelling to airport by rickshaw.");
        }

    }
}
