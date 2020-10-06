﻿using Bilance_Exchange.Domain.Entity;
using Bilance_Exchange.Domain.ValueObjects;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BilanceExchange.Repository.Context
{
    public class BilanceExchangeContext: DbContext
    { 
        public DbSet<User> Users { get; set; }
        public DbSet<Wallet> Wallets { get; set; }
        public DbSet<Currency> Currencies { get; set; }
        public DbSet<CoinBalance> CoinBalances { get; set; }
        public DbSet<UserType> UserType { get; set; }

        public BilanceExchangeContext( DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(BilanceExchangeContext).Assembly);

            modelBuilder.Entity<Currency>().HasData(new Currency[] {
                new Currency() { Id = 2, Name = "Bitcoin", ShortName = "BTC", MaxSupply = 21000000 },
                new Currency() { Id = 3, Name = "Dollar", ShortName = "USDR", MaxSupply = null}
            }
            );

            base.OnModelCreating(modelBuilder);
        }
    }
}
