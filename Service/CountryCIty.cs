using System.Collections.Generic;
using Core.Model;
using Data.Infrastructure;
using Data.Repositories;

namespace Service
{
    public interface ICountryService
    {
        Country GetCountry(int id);
        IEnumerable<Country> GetCountries();

        void CreateCountry(Country country);
        void UpdateCountry(Country country);
        void DeleteCountry(int id);
        void SaveCountry();
    }

    public class CountryService : ICountryService
    {
        private readonly ICountryRepository _countryRepository;
        private readonly IUnitOfWork _unitOfWork;

        public CountryService(ICountryRepository countryRepository, IUnitOfWork unitOfWork)
        {
            _countryRepository = countryRepository;
            _unitOfWork = unitOfWork;
        }

        #region ICountryServiceMembers

        public Country GetCountry(int id)
        {
            return _countryRepository.GetById(id);
        }

        public IEnumerable<Country> GetCountries()
        {
            return _countryRepository.GetAll();
        }

        public void CreateCountry(Country country)
        {
            _countryRepository.Add(country);
            SaveCountry();
        }

        public void UpdateCountry(Country country)
        {
            _countryRepository.Update(country);
            SaveCountry();
        }

        public void DeleteCountry(int id)
        {
            _countryRepository.Delete(_countryRepository.GetById(id));
            SaveCountry();
        }

        public void SaveCountry()
        {
            _unitOfWork.Commit();
        }

        #endregion
    }
}