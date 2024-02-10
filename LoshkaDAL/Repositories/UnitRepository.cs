using LoshkaDAL.Interfaces;
using LoshkaDAL.Models;
using Microsoft.EntityFrameworkCore;

namespace LoshkaDAL.Repositories
{
    public class UnitRepository(IAppDbContext context) : IUnitRepository
    {
        private readonly IAppDbContext _context = context;

        public async Task<IEnumerable<Unit>> FindAsync(ISpecification<Unit> spec) => await _context.Unit.Where(spec.Criteria).ToListAsync();

        public async Task<List<Unit>> GetAllUnitsAsync() => await _context.Unit.ToListAsync();

        public async Task<Unit> GetUnitByIdAsync(int unitId) => await _context.Unit.FindAsync(unitId);

        public async Task AddUnitAsync(string unitName, Unit unit)
        {
            var exists = await _context.Unit.AnyAsync(u => u.UnitName == unitName);
            if (exists)
            {
                throw new Exception("Unit already exists");
            }

            _context.Unit.Add(unit);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateUnitByIdAsync(int unitId, Unit unit)
        {
            var unitToUpdate = await _context.Unit.FindAsync(unitId);
            if (unitToUpdate != null)
            {
                unitToUpdate.UnitName = unit.UnitName;
                await _context.SaveChangesAsync();
            }
            else
            {
                throw new Exception("Unit not found");
            }
        }

        public async Task DeleteUnitByIdAsync(int unitId)
        {
            var unit = await _context.Unit.FindAsync(unitId);
            if (unit != null)
            {
                _context.Unit.Remove(unit);
                await _context.SaveChangesAsync();
            }
            else
            {
                throw new Exception("Unit not found");
            }
        }
    }
}