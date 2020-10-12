using Bilance_Exchange.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bilance_Exchange.Domain.Interfaces.Service
{
    public interface IUserService : IBaseService<User>
    {
        string HashPassword(String password);
        bool VerifyPassword(String password, byte[] hash);
    }
}
