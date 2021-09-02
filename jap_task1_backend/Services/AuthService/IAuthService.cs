using jap_task1_backend.DTO.User;
using jap_task1_backend.Models;
using System.Threading.Tasks;

namespace jap_task1_backend.Services.AuthService
{
    public interface IAuthService
    {
        Task<ServiceResponse<int>> Register(User user, string password);
        Task<ServiceResponse<UserLoginDTO>> Login(string email, string password);

    }
}
