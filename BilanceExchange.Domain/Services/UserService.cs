using Bilance_Exchange.Domain.Entity;
using Bilance_Exchange.Domain.Interfaces;
using Bilance_Exchange.Domain.Interfaces.Service;
using System;
using System.Collections.Generic;

namespace Bilance_Exchange.Domain.Services
{
    public class UserService : BaseService<User>, IUserService
    {
        public UserService(IBaseRepository<User> repository) : base(repository)
        {
        }
    }
}
