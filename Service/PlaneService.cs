using System.Collections.Generic;
using Core.Model;

namespace Service
{
    public interface IPlaneService
    {
        Plane GetPlane(int id);
        IEnumerable<Plane> GetPlanes();

        void CreatePlane();
        void UpdatePlane();
        void DeletePlane();
    }

    public class PlaneService
    {
    }
}
