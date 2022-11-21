using IdentityModel.Client;
using System.Threading.Tasks;

namespace WebMVC.Services
{
    public interface ITokenService
    {
        Task<TokenResponse> GetToken(string scope);
    }
}
