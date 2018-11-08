using Core.Model;
using Data.Infrastructure;

namespace Data.Repositories
{
    public class ServiceClassRepository : Repository<ServiceClass>, IServiceClassRepository
    {
        public ServiceClassRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }

    public interface IServiceClassRepository : IRepository<ServiceClass>
    {
    }
}
