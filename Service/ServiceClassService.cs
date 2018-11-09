using System.Collections.Generic;
using Core.Model;

namespace Service
{
    public interface IServiceClassService
    {
        ServiceClass GetServiceClass(int id);
        IEnumerable<ServiceClass> GetServiceClasses();

        void CreateServiceClass();
        void UpdateServiceClass();
        void DeleteServiceClass();
    }

    public class ServiceClassService
    {
    }
}
