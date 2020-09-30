using Bilance_Exchange.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bilance_Exchange.Domain.Entity
{
    public class User : Entity
    {
        private int Id { get; set; }
        private String Name { get; set; }
        private String Email { get; set; }
        private String Password { get; set; }
        private UserTypeEnum UserType { get; set; }

    }
}
