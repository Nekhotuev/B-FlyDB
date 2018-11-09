using System.Collections.Generic;
using Core.Model;

namespace Service
{
    public interface IGateService
    {
        Gate GetGate(int id);
        IEnumerable<Gate> GetGates();

        void CreateGate();
        void UpdateGate();
        void DeleteGate();
    }

    public class GateService
    {
    }
}
