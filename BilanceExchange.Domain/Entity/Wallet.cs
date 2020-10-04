using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Bilance_Exchange.Domain.Entity
{
    public class Wallet : Entity
    {
        public double TotalBalance { get; set; }
        public virtual ICollection<CoinBalance> Balances { get; set; }
        public int UserId { get; set; }
        public virtual User User { get; set; }
    }
}
