using System.Collections.Generic;
using Core.Model;

namespace Service
{
    public interface ICityService
    {
        City GetCity(int id);
        IEnumerable<City> GetCities();

        void CreateCity();
        void UpdateCity();
        void DeleteCity();
    }

    public class CityService
    {
    }
}
