using Core.Model;
using Data.Infrastructure;

namespace Data.Repositories
{
    public class GateRepository : Repository<Gate>, IGateRepository
    {
        public GateRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }

    public interface IGateRepository : IRepository<Gate>
    {
    }
}
