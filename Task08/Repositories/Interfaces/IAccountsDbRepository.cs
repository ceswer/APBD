using System.Threading.Tasks;
using Task08.DTOs;
using Task08.Helpers;

namespace Task08.Repositories.Interfaces
{
    public interface IAccountsDbRepository
    {
        public Task<DbAnswer> RegisterAsync(UserDto dto);
        public Task<LoginHelper> LoginAsync(UserDto dto);
        public Task<LoginHelper> UpdateAccessTokenAsync(RefreshTokenDto dto);
    }
}
