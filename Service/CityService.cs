using System.Collections.Generic;
using Core.Model;
using Data.Infrastructure;
using Data.Repositories;

namespace Service
{
    public interface ICityService
    {
        City GetCity(int id);
        IEnumerable<City> GetCities();

        void CreateCity(City city);
        void UpdateCity(City city);
        void DeleteCity(int id);
        void SaveCity();
    }

    public class CityService : ICityService
    {
        private readonly ICityRepository _cityRepository;
        private readonly IUnitOfWork _unitOfWork;

        public CityService(ICityRepository cityRepository, IUnitOfWork unitOfWork)
        {
            _cityRepository = cityRepository;
            _unitOfWork = unitOfWork;
        }

        #region ICityServiceMembers
        
        public City GetCity(int id)
        {
            return _cityRepository.GetById(id);
        }

        public IEnumerable<City> GetCities()
        {
            return _cityRepository.GetAll();
        }

        public void CreateCity(City city)
        {
            _cityRepository.Add(city);
            SaveCity();
        }

        public void UpdateCity(City city)
        {
            _cityRepository.Update(city);
            SaveCity();
        }

        public void DeleteCity(int id)
        {
            _cityRepository.Delete(_cityRepository.GetById(id));
            SaveCity();
        }

        public void SaveCity()
        {
            _unitOfWork.Commit();
        }

        #endregion
    }
}
