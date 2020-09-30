using Bilance_Exchange.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bilance_Exchange.Domain.Entity
{
    public class Currency
    {
        private int Id { get; set; }
        private String Name { get; set; }
        private String ShortName { get; set; }
        private String Password { get; set; }
        private UserType UserType { get; set; }
    }
}
