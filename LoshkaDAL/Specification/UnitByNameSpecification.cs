using LoshkaDAL.Interfaces;
using LoshkaDAL.Models;
using System.Linq.Expressions;

namespace LoshkaDAL.Specification
{
    public class UnitByNameSpecification(string unitName) : ISpecification<Unit>
    {
        public Expression<Func<Unit, bool>> Criteria { get; } = unit => unit.UnitName == unitName;
    }
}
