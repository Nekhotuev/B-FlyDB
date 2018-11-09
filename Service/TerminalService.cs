using System.Collections.Generic;
using Core.Model;

namespace Service
{
    public interface ITerminalService
    {
        Terminal GetTerminal(int id);
        IEnumerable<Terminal> GetTerminals();

        void CreateTerminal();
        void UpdateTerminal();
        void DeleteTerminal();
    }

    public class TerminalService
    {
    }
}
