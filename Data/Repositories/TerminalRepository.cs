using Core.Model;
using Data.Infrastructure;

namespace Data.Repositories
{
    public class TerminalRepository : Repository<Terminal>, ITerminalRepository
    {
        public TerminalRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }

    public interface ITerminalRepository : IRepository<Terminal>
    {
    }
}
