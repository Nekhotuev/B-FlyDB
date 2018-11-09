using System.Collections.Generic;
using Core.Model;

namespace Service
{
    public interface IAirportService
    {
        Airport GetAirport(int id);
        IEnumerable<Airport> GetAirports();

        void CreateAirport();
        void UpdateAirport();
        void DeleteAirport();
    }

    public class AirportService
    {
    }
}
