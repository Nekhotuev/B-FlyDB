using System.Collections.Generic;
using Core.Model;

namespace Service
{
    public interface ITimeTableService
    {
        TimeTable GetTimeTable(int id);
        IEnumerable<TimeTable> GetTimeTables();

        void CreateTimeTable();
        void UpdateTimeTable();
        void DeleteTimeTable();
    }

    public class TimeTableService
    {
    }
}
