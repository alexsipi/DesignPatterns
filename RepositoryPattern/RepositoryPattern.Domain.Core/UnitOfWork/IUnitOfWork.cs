using RepositoryPattern.Core;
using System;
using System.Collections.Generic;

namespace RepositoryPattern.RepositoryPattern.Domain.Core.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        public void Save();
    }
}
