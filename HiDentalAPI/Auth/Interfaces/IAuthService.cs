using Auth.Models;
using DatabaseLayer.Models;
using System.Threading.Tasks;

namespace Auth.Interfaces
{
    public interface IAuthService
    {
        Task<bool> SignIn(User model);
        Task<bool> Register(User model);
        Task<AuthResult> BuildToken(User model);
        string Test();
    }
}
