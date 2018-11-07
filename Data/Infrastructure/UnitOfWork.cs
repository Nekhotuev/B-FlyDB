namespace Data.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IDbFactory _dbFactory;
        private BflyContext _context;

        public UnitOfWork(IDbFactory dbFactory)
        {
            this._dbFactory = dbFactory;
        }

        protected BflyContext GetContext => _context ?? (_context = _dbFactory.Get());

        public void Commit()
        {
            GetContext.Commit();
        }
    }
}