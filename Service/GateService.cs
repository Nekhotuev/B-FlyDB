using System.Collections.Generic;
using System.Linq;
using Core.Model;
using Data.Infrastructure;
using Data.Repositories;

namespace Service
{
    public interface IGateService
    {
        Gate GetGate(int id);
        IEnumerable<Gate> GetGates();
        IEnumerable<IEnumerable<Gate>> GetGates(int airportId);

        void CreateGate(Gate gate);
        void UpdateGate(Gate gate);
        void DeleteGate(int id);
        void SaveGate();
    }

    public class GateService : IGateService
    {
        private readonly IGateRepository _gateRepository;
        private readonly IAirportRepository _airportRepository;
        private readonly IAirportSchemeRepository _airportSchemeRepository;
        private readonly ITerminalRepository _terminalRepository;
        private readonly IUnitOfWork _unitOfWork;

        public GateService(IGateRepository gateRepository, IAirportRepository airportRepository, IAirportSchemeRepository airportSchemeRepository, ITerminalRepository terminalRepository, IUnitOfWork unitOfWork)
        {
            _gateRepository = gateRepository;
            _airportRepository = airportRepository;
            _airportSchemeRepository = airportSchemeRepository;
            _terminalRepository = terminalRepository;
            _unitOfWork = unitOfWork;
        }



        #region IGateServiceMembers

        public Gate GetGate(int id)
        {
            return _gateRepository.GetById(id);
        }

        public IEnumerable<Gate> GetGates()
        {
            return _gateRepository.GetAll();
        }

        public void CreateGate(Gate gate)
        {
            _gateRepository.Add(gate);
            SaveGate();
        }

        public void UpdateGate(Gate gate)
        {
            _gateRepository.Update(gate);
            SaveGate();
        }

        public void DeleteGate(int id)
        {
            _gateRepository.Delete(_gateRepository.GetById(id));
            SaveGate();
        }

        public void SaveGate()
        {
            _unitOfWork.Commit();
        }
        
        public IEnumerable<IEnumerable<Gate>> GetGates(int airportId)
        {
            var airport = _airportRepository.GetById(airportId);
            var schemes = _airportSchemeRepository.GetMany(asch => asch.Airport == airport);
            var terminals = schemes.Select(s => s.Terminal).Distinct();
            List<List<Gate>> gates = new List<List<Gate>>();
            foreach (Terminal terminal in terminals)
            {
                gates.Add(schemes.Where(s => s.Terminal == terminal).Select(s => s.Gate).ToList());
            }

            return gates;
        }

        #endregion
    }
}
