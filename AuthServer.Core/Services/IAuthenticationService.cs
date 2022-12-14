using AuthServer.Core.Dtos;
using AuthServer.Shared.Dtos;
using System.Threading.Tasks;

namespace AuthServer.Core.Services
{
    public interface IAuthenticationService
    {
        Task<Response<TokenDto>> CreateTokenAsync(LoginDto loginDto);
        Task<Response<TokenDto>> CreateTokenByRefreshAsync(string refreshToken);
        Task<Response<NoDataDto>> RevokeRefreshTokenAsync(string refreshToken);
        Response<ClientTokenDto> CreateTokenByClientAsync(ClientLoginDto clientLoginDto);
    }
}