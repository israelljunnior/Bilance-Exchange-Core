using Bilance_Exchange.Domain.Entity;
using Bilance_Exchange.Domain.Interfaces;
using Bilance_Exchange.Domain.Interfaces.Service;
using Bilance_Exchange.Domain.Services.Security;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Bilance_Exchange.Domain.Services
{
    public class UserService : BaseService<User>, IUserService
    {
        private readonly Argon2Provider _argon2Provider;
        public UserService(IUserRepository repository) : base(repository)
        {
            this._argon2Provider = new Argon2Provider();
        }

        public String HashPassword(String password) {

            var salt = _argon2Provider.CreateSalt(16);
            var hash = _argon2Provider.HashPassword(password, salt);
            return Convert.ToBase64String(hash);
        }

        public bool VerifyPassword(string password, byte[] hash)
        {
            var salt = _argon2Provider.CreateSalt(16);
            return _argon2Provider.VerifyHash(password, salt, hash);
        }

    }
}
