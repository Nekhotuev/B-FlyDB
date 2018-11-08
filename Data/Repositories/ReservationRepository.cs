using Core.Model;
using Data.Infrastructure;

namespace Data.Repositories
{
    public class ReservationRepository : Repository<Reservation>, IReservationRepository
    {
        public ReservationRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }

    public interface IReservationRepository : IRepository<Reservation>
    {
    }
}
