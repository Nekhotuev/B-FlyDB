using Core.Model;
using Data.Infrastructure;

namespace Data.Repositories
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }

    public interface IUserRepository : IRepository<User>
    {
    }
}
