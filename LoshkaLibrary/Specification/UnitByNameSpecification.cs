using LoshkaLibrary.Interfaces;
using LoshkaLibrary.Models;
using System.Linq.Expressions;

namespace LoshkaLibrary.Specification
{
    public class UnitByNameSpecification(string unitName) : ISpecification<Unit>
    {
        public Expression<Func<Unit, bool>> Criteria { get; } = unit => unit.UnitName == unitName;
    }
}
