using System.Collections.Generic;
using Core.Model;
using Data.Infrastructure;
using Data.Repositories;

namespace Service
{
    public interface IGateService
    {
        Gate GetGate(int id);
        IEnumerable<Gate> GetGates();

        void CreateGate(Gate gate);
        void UpdateGate(Gate gate);
        void DeleteGate(int id);
        void SaveGate();
    }

    public class GateService : IGateService
    {
        private readonly IGateRepository _gateRepository;
        private readonly IUnitOfWork _unitOfWork;

        public GateService(IGateRepository gateRepository, IUnitOfWork unitOfWork)
        {
            _gateRepository = gateRepository;
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

        #endregion
    }
}
