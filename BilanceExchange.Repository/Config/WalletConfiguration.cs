using Bilance_Exchange.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bilance_Exchange.Repository.Config
{
    class WalletConfiguration : IEntityTypeConfiguration<Wallet>
    {
        public void Configure(EntityTypeBuilder<Wallet> builder)
        {
            builder.HasKey(w => w.Id);

            builder.Property(w => w.TotalBalance)
                .HasColumnType("decimal(19,4)")
                .IsRequired();

            builder
                .HasMany(w => w.Balances)
                .WithOne(b => b.Wallet)
                .IsRequired();
        }
    }
}
