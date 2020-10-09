using Bilance_Exchange.Domain.Interfaces;
using BilanceExchange.Repository.Context;
using Microsoft.EntityFrameworkCore.Diagnostics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bilance_Exchange.Repository.Repositories
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
    {
        private bool disposedValue;

        protected BilanceExchangeContext BilanceExchangeContext;

        public BaseRepository(BilanceExchangeContext BilanceExchangeContext)
        {
            this.BilanceExchangeContext = BilanceExchangeContext;
        }

        public void Save(TEntity entity)
        {
            this.BilanceExchangeContext.Set<TEntity>().Add(entity);
            this.BilanceExchangeContext.SaveChanges();
        }

        public IEnumerable<TEntity> findAll()
        {
            return this.BilanceExchangeContext.Set<TEntity>().ToList();
        }

        public TEntity findByID(int id)
        {
            return this.BilanceExchangeContext.Set<TEntity>().Find(id);
        }

        public void remove(int id)
        {
            TEntity entity = this.BilanceExchangeContext.Set<TEntity>().Find(id);
            this.BilanceExchangeContext.Set<TEntity>().Remove(entity);
            this.BilanceExchangeContext.SaveChanges();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects)
                }

                // TODO: free unmanaged resources (unmanaged objects) and override finalizer
                // TODO: set large fields to null
                disposedValue = true;
            }
        }

        // // TODO: override finalizer only if 'Dispose(bool disposing)' has code to free unmanaged resources
        // ~BaseRepository()
        // {
        //     // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
        //     Dispose(disposing: false);
        // }

        public void Dispose()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}
