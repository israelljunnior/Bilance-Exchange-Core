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
            builder.HasKey(c => c.Id);

            builder.Property(cb => cb.Balance)
                .HasColumnType("decimal(19,4)")
                .IsRequired()
                .HasMaxLength(255);

            builder.Property(cb => cb.Address)
                .IsRequired()
                .HasMaxLength(255);

            builder.Property(cb => cb.Balance)
                .IsRequired()
                .HasMaxLength(255);

            builder
                .HasOne(cb => cb.Currency);
        }
    }
}
