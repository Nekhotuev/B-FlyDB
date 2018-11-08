using Core.Model;
using Data.Infrastructure;

namespace Data.Repositories
{
    public class CityRepository : Repository<City>, ICityRepository
    {
        public CityRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }

    public interface ICityRepository : IRepository<City>
    {
    }
}
