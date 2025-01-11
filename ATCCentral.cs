using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirTrafficControlSystem
{
    internal class ATCCentral : IATCMediator
    {
        private List<Flight> flights = new List<Flight>();
    public void registerFlight(Flight flight)
        {
            flights.Add(flight);
            flight.setMediator(this);
        }

    public void deregisterFlight(Flight flight)
        {
            flights.Remove(flight);
            flight.setMediator(null);
        }

    public void requestLanding(Flight flight)
        {
           Console.WriteLine("Flight " + flight.getId() + " requesting permission to land");
            foreach (Flight f in flights)
            {
                if (f != flight)
                {
                    f.notifyLandingRequest(flight);
                }
            }
        }

    public void grantLanding(Flight flight)
        {
            Console.WriteLine("Flight " + flight.getId() + " granted permission to land");
            flight.land();
        }

    public void denyLanding(Flight flight)
        {
            Console.WriteLine("Landing denied for flight " + flight.getId());
            flight.denyLanding();
        }
    }
}
