using System.Collections.Generic;
using Core.Model;
using Data.Infrastructure;
using Data.Repositories;

namespace Service
{
    public interface IServiceClassService
    {
        ServiceClass GetServiceClass(int id);
        IEnumerable<ServiceClass> GetServiceClasses();

        void CreateServiceClass(ServiceClass serviceClass);
        void UpdateServiceClass(ServiceClass serviceClass);
        void DeleteServiceClass(int id);
        void SaveServiceClass();
    }

    public class ServiceClassService : IServiceClassService
    {
        private readonly IServiceClassRepository _serviceClassRepository;
        private readonly IUnitOfWork _unitOfWork;

        public ServiceClassService(IServiceClassRepository serviceClassRepository, IUnitOfWork unitOfWork)
        {
            _serviceClassRepository = serviceClassRepository;
            _unitOfWork = unitOfWork;
        }

        #region IServiceClassServiceMembers
        
        public ServiceClass GetServiceClass(int id)
        {
            return _serviceClassRepository.GetById(id);
        }

        public IEnumerable<ServiceClass> GetServiceClasses()
        {
            return _serviceClassRepository.GetAll();
        }

        public void CreateServiceClass(ServiceClass serviceClass)
        {
            _serviceClassRepository.Add(serviceClass);
            SaveServiceClass();
        }

        public void UpdateServiceClass(ServiceClass serviceClass)
        {
            _serviceClassRepository.Update(serviceClass);
            SaveServiceClass();
        }

        public void DeleteServiceClass(int id)
        {
            _serviceClassRepository.Delete(_serviceClassRepository.GetById(id));
            SaveServiceClass();
        }

        public void SaveServiceClass()
        {
            _unitOfWork.Commit();
        }

        #endregion
    }
}
