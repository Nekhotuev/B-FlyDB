using System.Collections.Generic;
using Core.Model;
using Data.Infrastructure;
using Data.Repositories;

namespace Service
{
    public interface IAirportService
    {
        Airport GetAirport(int id);
        IEnumerable<Airport> GetAirports();

        void CreateAirport(Airport airport);
        void UpdateAirport(Airport airport);
        void DeleteAirport(int id);
        void SaveAirport();
    }

    public class AirportService : IAirportService
    {
        private readonly IAirportRepository _airportRepository;
        private readonly IUnitOfWork _unitOfWork;

        public AirportService(IAirportRepository airportRepository, IUnitOfWork unitOfWork)
        {
            _airportRepository = airportRepository;
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

        public void CreateAirport(Airport airport)
        {
            _airportRepository.Add(airport);
            SaveAirport();
        }

        public void UpdateAirport(Airport airport)
        {
            _airportRepository.Update(airport);
            SaveAirport();
        }

        public void DeleteAirport(int id)
        {
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
