using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace AuthServer.Service.Services
{
    public class SignService
    {
        public static SecurityKey GetSymemetricSecurityKey(string securityKey)
        {
            return new SymmetricSecurityKey(Encoding.UTF8.GetBytes(securityKey));
        }
    }
}