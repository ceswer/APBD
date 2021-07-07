using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Task08.DTOs;
using Task08.Helpers;
using Task08.Repositories.Interfaces;

namespace Task08.Controllers
{
    [Route("api/accounts")]
    [ApiController]
    public class AccountsController : ControllerBase
    {
        private readonly IAccountsDbRepository repository;

        public AccountsController(IAccountsDbRepository repository)
        {
            this.repository = repository;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register(UserDto dto)
        {
            var result = await repository.RegisterAsync(dto);

            switch (result)
            {
                case DbAnswer.OK:
                    return Ok("Successfully registered!");
                case DbAnswer.PasswordLengthIsNotProper:
                    return BadRequest("Password should contain at least 6 characters!");
                case DbAnswer.UserIsAlreadyRegistered:
                    return BadRequest("User with the same login is alredy registered!");
                default:
                    return StatusCode(500);
            }
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(UserDto dto)
        {
            var result = await repository.LoginAsync(dto);

            switch (result.DbAnswer)
            {
                case DbAnswer.OK:
                    return Ok(result);
                case DbAnswer.BadPassword:
                    return Unauthorized("Entered password is wrong!");
                case DbAnswer.UserNotFound:
                    return Unauthorized("Entered login is not found!");
                default:
                    return Unauthorized();
            }
        }

        [HttpPost("updateAccessToken")]
        public async Task<IActionResult> UpdateAccessToken(RefreshTokenDto dto)
        {
            var result = await repository.UpdateAccessTokenAsync(dto);

            switch (result.DbAnswer)
            {
                case DbAnswer.OK:
                    return Ok(result);
                case DbAnswer.RefreshTokenIsExpired:
                    return BadRequest("Refresh token is expired!");
                case DbAnswer.UserNotFound:
                    return BadRequest("User is not found!");
                default:
                    return Unauthorized();
            }
        }
    }
}
