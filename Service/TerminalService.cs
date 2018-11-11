using System.Collections.Generic;
using Core.Model;
using Data.Infrastructure;
using Data.Repositories;

namespace Service
{
    public interface ITerminalService
    {
        Terminal GetTerminal(int id);
        IEnumerable<Terminal> GetTerminals();

        void CreateTerminal(Terminal terminal);
        void UpdateTerminal(Terminal terminal);
        void DeleteTerminal(int id);
        void SaveTerminal();
    }

    public class TerminalService : ITerminalService
    {
        private readonly ITerminalRepository _terminalRepository;
        private readonly IUnitOfWork _unitOfWork;

        public TerminalService(ITerminalRepository terminalRepository, IUnitOfWork unitOfWork)
        {
            _terminalRepository = terminalRepository;
            _unitOfWork = unitOfWork;
        }

        #region ITerminalServiceMembers
        
        public Terminal GetTerminal(int id)
        {
            return _terminalRepository.GetById(id);
        }

        public IEnumerable<Terminal> GetTerminals()
        {
            return _terminalRepository.GetAll();
        }

        public void CreateTerminal(Terminal terminal)
        {
            _terminalRepository.Add(terminal);
            SaveTerminal();
        }

        public void UpdateTerminal(Terminal terminal)
        {
            _terminalRepository.Update(terminal);
            SaveTerminal();
        }

        public void DeleteTerminal(int id)
        {
            _terminalRepository.Delete(_terminalRepository.GetById(id));
            SaveTerminal();
        }

        public void SaveTerminal()
        {
            _unitOfWork.Commit();
        }

        #endregion
    }
}
