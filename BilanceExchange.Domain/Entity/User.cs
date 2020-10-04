using Bilance_Exchange.Domain.Enum;
using Bilance_Exchange.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bilance_Exchange.Domain.Entity
{
    public class User : Entity
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public String Email { get; set; }
        public String Password { get; set; }
        public virtual Wallet Wallet { get; set; }
        public int UserTypeId { get; set; }
        public virtual UserType UserType { get; set; }

    }
}
