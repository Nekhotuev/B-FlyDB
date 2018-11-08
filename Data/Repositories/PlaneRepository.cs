using Core.Model;
using Data.Infrastructure;

namespace Data.Repositories
{
    public class PlaneRepository : Repository<Plane>, IPlaneRepository
    {
        public PlaneRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }

    public interface IPlaneRepository : IRepository<Plane>
    {
    }
}
