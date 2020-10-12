using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bilance_Exchange.Domain.Entity;
using Bilance_Exchange.Domain.Interfaces;
using Bilance_Exchange.Domain.Interfaces.Service;
using Bilance_Exchange.Domain.Validators;
using Bilance_Exchange.Repository.Repositories;
using FluentValidation;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Bilance_Exchange.Controllers
{
    [Route("api/user")]
    [ApiController]
    public class UserController : ControllerBase
    {   
        private readonly IUserService _userService;
        private readonly IHttpContextAccessor _httpContextAccesso;
        public UserController(IUserService UserService, IHttpContextAccessor http)
        {
            this._userService = UserService;
            _httpContextAccesso = http;
        }

        [HttpPost("save")]
        public IActionResult Save([FromBody] User User) {
            var validator = new UserValidator();
            var results = validator.Validate(User);
            if (results.IsValid) {
                var EncryptedPassword = this._userService.HashPassword(User.Password);
                User.Password = EncryptedPassword;
                this._userService.Add(User);
                return Ok(User);
            }
            return BadRequest(results.Errors);
        }
    }
}
