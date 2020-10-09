using Bilance_Exchange.Domain.Entity;
using Bilance_Exchange.Domain.Interfaces;
using BilanceExchange.Repository.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bilance_Exchange.Repository.Repositories
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {

        private bool disposedValue;

        public UserRepository(BilanceExchangeContext BilanceExchangeContext) : base(BilanceExchangeContext)
        {

        }


    }
}
