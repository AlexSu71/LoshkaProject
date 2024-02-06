using LoshkaLibrary.Models;

namespace LoshkaLibrary.Interfaces
{
    public interface IUnitRepository
    {
        Task<List<Unit>> GetAllUnitsAsync();
        Task<Unit> GetUnitByIdAsync(int unitId);
        Task AddUnitAsync(string unitName, Unit unit);
        Task UpdateUnitByIdAsync(int unitId, Unit unit);
        Task DeleteUnitByIdAsync(int unitId);
        Task<IEnumerable<Unit>> FindAsync(ISpecification<Unit> specification);
    }
}