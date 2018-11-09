using System.Collections.Generic;
using Core.Model;

namespace Service
{
    public interface IReservationService
    {
        Reservation GetReservation(int id);
        IEnumerable<Reservation> GetReservations();

        void CreateReservation();
        void UpdateReservation();
        void DeleteReservation();
    }

    public class ReservationService
    {
    }
}
