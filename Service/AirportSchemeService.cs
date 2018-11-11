using System.Collections.Generic;
using Core.Model;
using Data.Infrastructure;
using Data.Repositories;

namespace Service
{
    public interface IAirportSchemeService
    {
        AirportScheme GetAirportScheme(int id);

        void CreateAirportScheme(AirportScheme airportScheme);
        void UpdateAirportScheme(AirportScheme airportScheme);
        void DeleteAirportScheme(int id);
        void SaveAirportScheme();
    }

    public class AirportSchemeService : IAirportSchemeService
    {
        private readonly IAirportSchemeRepository _airportSchemeRepository;
        private readonly IUnitOfWork _unitOfWork;

        public AirportSchemeService(IAirportSchemeRepository airportSchemeRepository, IUnitOfWork unitOfWork)
        {
            _airportSchemeRepository = airportSchemeRepository;
            _unitOfWork = unitOfWork;
        }

        #region IAirportSchemeMembers

        public AirportScheme GetAirportScheme(int id)
        {
            return _airportSchemeRepository.GetById(id);
        }

        public void CreateAirportScheme(AirportScheme airportScheme)
        {
            _airportSchemeRepository.Add(airportScheme);
            SaveAirportScheme();
        }

        public void UpdateAirportScheme(AirportScheme airportScheme)
        {
            _airportSchemeRepository.Update(airportScheme);
            SaveAirportScheme();
        }

        public void DeleteAirportScheme(int id)
        {
            _airportSchemeRepository.Delete(_airportSchemeRepository.GetById(id));
            SaveAirportScheme();
        }

        public void SaveAirportScheme()
        {
            _unitOfWork.Commit();
        }

        #endregion
    }
}
