using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Infrastructure
{
    public class DbFactory : IDbFactory
    {
        private BflyContext _context;

        public BflyContext Get()
        {
            return _context ?? (_context = new BflyContext());
        }
        
        public void Dispose()
        {
            _context?.Dispose();
        }
    }
}
