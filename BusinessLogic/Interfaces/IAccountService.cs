using BusinessLogic.ApiModels.Accounts;
using Core.Dtos;

namespace BusinessLogic.Interfaces
{
    public interface IAccountService
    {
        Task RegisterAsync(RegisterRequest model);
        Task<LoginResponse> LoginAsync(LoginRequest model);
        Task LogoutAsync();
    }
}
