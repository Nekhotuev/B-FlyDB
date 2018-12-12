using System;
using System.Collections.Generic;
using System.Linq;
using Core.Model;
using Data.Infrastructure;
using Data.Repositories;

namespace Service
{
    public interface IAirportService
    {
        Airport GetAirport(int id);
        IEnumerable<Airport> GetAirports();
        IEnumerable<Airport> GetAirports(string searchText);
        IEnumerable<string> GetAirportNames(string searchText);

        void CreateAirport(Airport airport);
        void UpdateAirport(Airport airport);
        void DeleteAirport(int id);
        void SaveAirport();
    }

    public class AirportService : IAirportService
    {
        private readonly IAirportRepository _airportRepository;
        private readonly IAirportSchemeRepository _airportSchemeRepository;
        private readonly ICityService _cityService;
        private readonly IUnitOfWork _unitOfWork;

        public AirportService(IAirportRepository airportRepository, IAirportSchemeRepository airportSchemeRepository, ICityService cityService, IUnitOfWork unitOfWork)
        {
            _airportRepository = airportRepository;
            _airportSchemeRepository = airportSchemeRepository;
            _cityService = cityService;
            _unitOfWork = unitOfWork;
        }

        #region IAirportServcieMembers
        
        public Airport GetAirport(int id)
        {
            return _airportRepository.GetById(id);
        }

        public IEnumerable<Airport> GetAirports()
        {
            return _airportRepository.GetAll();
        }

        public IEnumerable<Airport> GetAirports(string searchText)
        {
            if (!String.IsNullOrEmpty(searchText))
            {
                return _airportRepository.GetMany(a => a.Name.Contains(searchText));
            }
            else
            {
                return _airportRepository.GetAll();
            }
        }

        public IEnumerable<string> GetAirportNames(string searchText)
        {
            if (!String.IsNullOrEmpty(searchText))
            {
                return _airportRepository.GetMany(a => a.Name.Contains(searchText)).Select(a => a.Name).ToList();
            }
            else
            {
                return _airportRepository.GetAll().Select(a => a.Name).ToList();
            }
        }

        public void CreateAirport(Airport airport)
        {
            _airportRepository.Add(airport);
            SaveAirport();
        }

        public void UpdateAirport(Airport airport)
        {
            airport.City = _cityService.GetCity(airport.CityId);
            _airportRepository.Update(airport);
            SaveAirport();
        }

        public void DeleteAirport(int id)
        {
            Airport airport = _airportRepository.GetById(id);
            List<AirportScheme> schemes =
                _airportSchemeRepository.GetMany(a => a.Airport.Id == airport.Id).ToList();
            foreach (AirportScheme scheme in schemes)
            {
                _airportSchemeRepository.Delete(scheme);
            }
            _airportRepository.Delete(_airportRepository.GetById(id));
            SaveAirport();
        }

        public void SaveAirport()
        {
            _unitOfWork.Commit();
        }

        #endregion
    }
}
