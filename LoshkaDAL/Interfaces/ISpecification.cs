using System.Linq.Expressions;

namespace LoshkaDAL.Interfaces
{
    public interface ISpecification<T>
    {
        Expression<Func<T, bool>> Criteria { get; }
    }
}
