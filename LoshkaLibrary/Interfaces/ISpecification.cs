﻿using System.Linq.Expressions;

namespace LoshkaLibrary.Interfaces
{
    public interface ISpecification<T>
    {
        Expression<Func<T, bool>> Criteria { get; }
    }
}
