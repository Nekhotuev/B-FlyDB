using System.Collections.Generic;
using Core.Model;
using Data.Infrastructure;
using Data.Repositories;

namespace Service
{
    public interface ITimeTableService
    {
        TimeTable GetTimeTable(int id);
        IEnumerable<TimeTable> GetTimeTables();

        void CreateTimeTable(TimeTable timeTable);
        void UpdateTimeTable(TimeTable timeTable);
        void DeleteTimeTable(int id);
        void SaveTimeTable();
    }

    public class TimeTableService : ITimeTableService
    {
        private readonly ITimeTableRepository _timeTableRepository;
        private readonly IUnitOfWork _unitOfWork;

        public TimeTableService(ITimeTableRepository timeTableRepository, IUnitOfWork unitOfWork)
        {
            _timeTableRepository = timeTableRepository;
            _unitOfWork = unitOfWork;
        }

        #region ITimeTableMembers
        
        public TimeTable GetTimeTable(int id)
        {
            return _timeTableRepository.GetById(id);
        }

        public IEnumerable<TimeTable> GetTimeTables()
        {
            return _timeTableRepository.GetAll();
        }

        public void CreateTimeTable(TimeTable timeTable)
        {
            _timeTableRepository.Add(timeTable);
            SaveTimeTable();
        }

        public void UpdateTimeTable(TimeTable timeTable)
        {
            _timeTableRepository.Update(timeTable);
            SaveTimeTable();
        }

        public void DeleteTimeTable(int id)
        {
            _timeTableRepository.Delete(_timeTableRepository.GetById(id));
            SaveTimeTable();
        }

        public void SaveTimeTable()
        {
            _unitOfWork.Commit();
        }
        
        #endregion
    }
}
