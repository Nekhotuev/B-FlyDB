using System.Collections.Generic;
using Core.Model;

namespace Service
{
    public interface ICountryService
    {
        Country GetCountry(int id);
        IEnumerable<Country> GetCountries();

        void CreateCountry();
        void UpdateCountry();
        void DeleteCountry();
    }

    public class CountryService
    {
    }
}
