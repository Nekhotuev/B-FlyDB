using System.Collections.Generic;
using Core.Model;

namespace Service
{
    public interface IAirportSchemeService
    {
        AirportScheme GetAirportScheme(int id);
        //IEnumerable<Airport> GetAirports();

        void CreateAirportScheme();
        void UpdateAirportScheme();
        void DeleteAirportScheme();
    }

    public class AirportSchemeService
    {
    }
}
