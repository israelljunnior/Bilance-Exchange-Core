using Bilance_Exchange.Domain.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Bilance_Exchange.Domain.Entity
{
    public class Currency : Entity
    {
        public String Name { get; set; }
        public String ShortName { get; set; }
        public double? MaxSupply { get; set; }
       
    }
}
