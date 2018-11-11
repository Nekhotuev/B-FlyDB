using System.Collections.Generic;
using System.Diagnostics;
using Core.Model;
using Data.Infrastructure;
using Data.Repositories;

namespace Service
{
    public interface IPlaneService
    {
        Plane GetPlane(int id);
        IEnumerable<Plane> GetPlanes();

        void CreatePlane(Plane plane);
        void UpdatePlane(Plane plane);
        void DeletePlane(int id);
        void SavePlane();
    }

    public class PlaneService : IPlaneService
    {
        private readonly IPlaneRepository _planeRepository;
        private readonly IUnitOfWork _unitOfWork;

        public PlaneService(IPlaneRepository planeRepository, IUnitOfWork unitOfWork)
        {
            _planeRepository = planeRepository;
            _unitOfWork = unitOfWork;
        }

        #region IPlainServiceMembers
        
        public Plane GetPlane(int id)
        {
            return _planeRepository.GetById(id);
        }

        public IEnumerable<Plane> GetPlanes()
        {
            return _planeRepository.GetAll();
        }

        public void CreatePlane(Plane plane)
        {
            _planeRepository.Add(plane);
            SavePlane();
        }

        public void UpdatePlane(Plane plane)
        {
            _planeRepository.Update(plane);
            SavePlane();
        }

        public void DeletePlane(int id)
        {
            _planeRepository.Delete(_planeRepository.GetById(id));
            SavePlane();
        }

        public void SavePlane()
        {
            _unitOfWork.Commit();
        }
        
        #endregion
    }
}
