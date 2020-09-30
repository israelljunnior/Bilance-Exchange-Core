using System;
using System.Collections.Generic;
using System.Text;

namespace Bilance_Exchange.Domain.Interfaces
{
    public interface IBaseRepository<TEntity> : IDisposable where TEntity : class
    {
        TEntity findByID(int id);
        IEnumerable<TEntity> findAll();
        void remove(int id);
    }
}
