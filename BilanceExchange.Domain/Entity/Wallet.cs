using System;
using System.Collections.Generic;
using System.Text;

namespace Bilance_Exchange.Domain.Entity
{
    public class Wallet : Entity
    {
        private int Id { get; set; }
        private double TotalBalance { get; set; }
        private User User { get; set; }

        private List<CoinBalance> balances { get; set; }

    }
}
