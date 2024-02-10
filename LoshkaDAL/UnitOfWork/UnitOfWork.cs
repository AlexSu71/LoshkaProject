using LoshkaDAL.Interfaces;
using LoshkaDAL.Repositories;

namespace LoshkaDAL.UnitOfWork
{
    public class UnitOfWork(IAppDbContext context) : IUnitOfWork
    {
        private readonly IAppDbContext _context = context;
        public IUnitRepository UnitRepository { get; } = new UnitRepository(context);

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public async Task<int> CompleteAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public void Dispose() => _context.Dispose();
    }
}
