using Bilance_Exchange.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bilance_Exchange.Domain.Entity
{
    public class Currency : Entity
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public String ShortName { get; set; }
        public String Password { get; set; }
    }
}
