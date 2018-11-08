using Core.Model;
using Data.Infrastructure;

namespace Data.Repositories
{
    public class FlightRepository : Repository<Flight>, IFlightRepository
    {
        public FlightRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }

    public interface IFlightRepository : IRepository<Flight>
    {
    }
}
