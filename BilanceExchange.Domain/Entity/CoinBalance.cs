using System;
using System.Collections.Generic;
using System.Text;

namespace Bilance_Exchange.Domain.Entity
{
    public class CoinBalance : Entity
    {
        private Currency currency { get; set; }
        private double balance{ get; set; }
        private String Address { get; set; }
    }
}
