using Bilance_Exchange.Domain.Entity;
using Bilance_Exchange.Domain.ValueObjects;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BilanceExchange.Repository.Context
{
    class BilanceExhangeContext: DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Wallet> Wallets { get; set; }
        public DbSet<Currency> Currencies { get; set; }
        public DbSet<CoinBalance> CoinBalances { get; set; }
        public DbSet<UserType> UserType { get; set; }
    }
}
