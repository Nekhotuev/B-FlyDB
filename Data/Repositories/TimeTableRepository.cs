using Core.Model;
using Data.Infrastructure;

namespace Data.Repositories
{
    public class TimeTableRepository : Repository<TimeTable>, ITimeTableRepository
    {
        public TimeTableRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }

    public interface ITimeTableRepository : IRepository<TimeTable>
    {
    }
}
