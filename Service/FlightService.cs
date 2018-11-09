using System.Collections.Generic;
using Core.Model;

namespace Service
{
    public interface IFlightService
    {
        Flight GetFlight(int id);
        IEnumerable<Flight> GetFlights();

        void CreateFlight();
        void UpdateFlight();
        void DeleteFlight();
    }

    public class FlightService
    {
    }
}
