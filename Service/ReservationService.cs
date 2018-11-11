using System.Collections.Generic;
using Core.Model;
using Data.Infrastructure;
using Data.Repositories;

namespace Service
{
    public interface IReservationService
    {
        Reservation GetReservation(int id);
        IEnumerable<Reservation> GetReservations();

        void CreateReservation(Reservation reservation);
        void UpdateReservation(Reservation reservation);
        void DeleteReservation(int id);
        void SaveReservation();
    }

    public class ReservationService : IReservationService
    {
        private readonly IReservationRepository _reservationRepository;
        private readonly IUnitOfWork _unitOfWork;

        public ReservationService(IReservationRepository reservationRepository, IUnitOfWork unitOfWork)
        {
            _reservationRepository = reservationRepository;
            _unitOfWork = unitOfWork;
        }

        #region IReservationServiceMembers

        public Reservation GetReservation(int id)
        {
            return _reservationRepository.GetById(id);
        }

        public IEnumerable<Reservation> GetReservations()
        {
            return _reservationRepository.GetAll();
        }

        public void CreateReservation(Reservation reservation)
        {
            _reservationRepository.Add(reservation);
            SaveReservation();
        }

        public void UpdateReservation(Reservation reservation)
        {
            _reservationRepository.Update(reservation);
            SaveReservation();
        }

        public void DeleteReservation(int id)
        {
            _reservationRepository.Delete(_reservationRepository.GetById(id));
            SaveReservation();
        }

        public void SaveReservation()
        {
            _unitOfWork.Commit();
        }

        #endregion
    }
}
