using Core.Model;
using Data.Infrastructure;

namespace Data.Repositories
{
    public class AirportRepository : Repository<Airport>, IAirportRepository
    {
        public AirportRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }

    public interface IAirportRepository : IRepository<Airport> { }
}
