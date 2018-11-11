using System.Collections.Generic;
using Core.Model;
using Data.Infrastructure;
using Data.Repositories;

namespace Service
{
    public interface IFlightService
    {
        Flight GetFlight(int id);
        IEnumerable<Flight> GetFlights();

        void CreateFlight(Flight flight);
        void UpdateFlight(Flight flight);
        void DeleteFlight(int id);
        void SaveFlight();
    }

    public class FlightService : IFlightService
    {
        private readonly IFlightRepository _flightRepository;
        private readonly IUnitOfWork _unitOfWork;

        public FlightService(IFlightRepository flightRepository, IUnitOfWork unitOfWork)
        {
            _flightRepository = flightRepository;
            _unitOfWork = unitOfWork;
        }

        #region IFlightServiceMembers
        
        public Flight GetFlight(int id)
        {
            return _flightRepository.GetById(id);
        }

        public IEnumerable<Flight> GetFlights()
        {
            return _flightRepository.GetAll();
        }

        public void CreateFlight(Flight flight)
        {
            _flightRepository.Add(flight);
            SaveFlight();
        }

        public void UpdateFlight(Flight flight)
        {
            _flightRepository.Update(flight);
            SaveFlight();
        }

        public void DeleteFlight(int id)
        {
            _flightRepository.Delete(_flightRepository.GetById(id));
            SaveFlight();
        }

        public void SaveFlight()
        {
            _unitOfWork.Commit();
        }

        #endregion
    }
}
