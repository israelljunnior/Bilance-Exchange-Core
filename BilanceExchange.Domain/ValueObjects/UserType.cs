using Bilance_Exchange.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bilance_Exchange.Domain.ValueObjects
{
    public class UserType : ValueObject<UserType>
    {
       private int Id { get; set; }
       private UserTypeEnum userType { get; set; }
    }
}
