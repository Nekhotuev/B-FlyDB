using Core.Model;
using Data.Infrastructure;

namespace Data.Repositories
{
    class CountryRepository : Repository<Country>, ICountryRepository
    {
        public CountryRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }

    public interface ICountryRepository : IRepository<Country>
    {
    }
}
