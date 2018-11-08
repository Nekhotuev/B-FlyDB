using Core.Model;
using Data.Infrastructure;

namespace Data.Repositories
{
    public class AirportSchemeRepository : Repository<AirportScheme>, IAirportSchemeRepository
    {
        public AirportSchemeRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }

    public interface IAirportSchemeRepository : IRepository<AirportScheme>
    {
    }
}
