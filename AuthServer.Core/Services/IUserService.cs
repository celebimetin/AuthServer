using AuthServer.Core.Dtos;
using AuthServer.Shared.Dtos;
using System.Threading.Tasks;

namespace AuthServer.Core.UnitOfWork
{
    public interface IUserService
    {
        Task<Response<UserAppDto>> CreateUserAsync(CreateUserDto createUserDto);
        Task<Response<UserAppDto>> GetUserByNameAsync(string userName);
    }
}