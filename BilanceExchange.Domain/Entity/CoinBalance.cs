using System;
using System.Collections.Generic;
using System.Text;

namespace Bilance_Exchange.Domain.Entity
{
    public class CoinBalance : Entity
    {
        public int CurrencyId { get; set; }
        public virtual Currency Currency { get; set; }
        public double Balance { get; set; }
        public String Address { get; set; }
        public virtual  Wallet Wallet { get; set; }
    }
}
