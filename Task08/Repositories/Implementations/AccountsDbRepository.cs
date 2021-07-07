using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Task08.DTOs;
using Task08.Helpers;
using Task08.Models;
using Task08.Repositories.Interfaces;

namespace Task08.Repositories.Implementations
{
    public class AccountsDbRepository : IAccountsDbRepository
    {
        private readonly Context context;
        private readonly IConfiguration configuration;

        public AccountsDbRepository(Context context, IConfiguration configuration)
        {
            this.context = context;
            this.configuration = configuration;
        }

        public async Task<DbAnswer> RegisterAsync(UserDto dto)
        {
            if (dto.Password.Length < 6) return DbAnswer.PasswordLengthIsNotProper;

            var checkUser = await context.User.FirstOrDefaultAsync(e => e.Login == dto.Login);
            if (checkUser != null) return DbAnswer.UserIsAlreadyRegistered;

            var hashedPwdAndSalt = SecurityHelper.GetHashedPasswordAndSalt(dto.Password);
            var user = new User
            {
                Login = dto.Login,
                Password = hashedPwdAndSalt.Item1,
                Salt = hashedPwdAndSalt.Item2,
                RefreshToken = Guid.NewGuid().ToString(),
                RerfreshTokenExpiration = DateTime.Now.AddHours(12)
            };

            await context.User.AddAsync(user);
            await context.SaveChangesAsync();

            return DbAnswer.OK;
        }

        public async Task<LoginHelper> LoginAsync(UserDto dto)
        {
            var wantedUser = await context.User.FirstOrDefaultAsync(e => e.Login == dto.Login);
            if (wantedUser == null)
                return new LoginHelper(DbAnswer.UserNotFound);

            if (wantedUser.Password != SecurityHelper.GetHashedSaltedPassword(dto.Password, wantedUser.Salt))
                return new LoginHelper(DbAnswer.BadPassword);

            var token = GetToken();

            wantedUser.RefreshToken = Guid.NewGuid().ToString();
            wantedUser.RerfreshTokenExpiration = DateTime.Now.AddHours(12);

            await context.SaveChangesAsync();

            return new LoginHelper(DbAnswer.OK, new JwtSecurityTokenHandler().WriteToken(token).ToString(), wantedUser.RefreshToken);
        }

        public async Task<LoginHelper> UpdateAccessTokenAsync(RefreshTokenDto dto)
        {
            var wantedUser = await context.User.FirstOrDefaultAsync(e => e.RefreshToken == dto.RefreshToken);
            if (wantedUser == null)
                return new LoginHelper(DbAnswer.UserNotFound);

            if (wantedUser.RerfreshTokenExpiration < DateTime.Now)
                return new LoginHelper(DbAnswer.RefreshTokenIsExpired);

            var token = GetToken();

            wantedUser.RefreshToken = Guid.NewGuid().ToString();
            wantedUser.RerfreshTokenExpiration = DateTime.Now.AddHours(12);

            await context.SaveChangesAsync();

            return new LoginHelper(DbAnswer.OK, new JwtSecurityTokenHandler().WriteToken(token).ToString(), wantedUser.RefreshToken);
        }

        public JwtSecurityToken GetToken()
        {
            Claim[] userClaims = new[]
            {
                new Claim(ClaimTypes.Role, "user"),
                new Claim(ClaimTypes.Role, "client")
            };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["Secret"]));
            var credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                issuer: "http://localhost",
                audience: "http://localhost",
                claims: userClaims,
                expires: DateTime.Now.AddMinutes(10),
                signingCredentials: credentials);

            return token;
        }
    }
}
