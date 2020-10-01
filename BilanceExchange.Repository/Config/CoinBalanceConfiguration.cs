using Bilance_Exchange.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bilance_Exchange.Repository.Config
{
    class CoinBalanceConfiguration : IEntityTypeConfiguration<CoinBalance>
    {
        public void Configure(EntityTypeBuilder<CoinBalance> builder)
        {
            throw new NotImplementedException();
        }
    }
}
