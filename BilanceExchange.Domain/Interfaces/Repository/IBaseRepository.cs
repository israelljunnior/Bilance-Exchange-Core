using System;
using System.Collections.Generic;
using System.Text;

namespace Bilance_Exchange.Domain.Interfaces
{
    public interface IBaseRepository<TEntity> : IDisposable where TEntity : class
    {
        void Add(TEntity obj);
        TEntity GetById(int id);
        IEnumerable<TEntity> GetAll();
        void Update(TEntity obj);
        void Remove(TEntity obj);
        void Dispose();
    }
}
