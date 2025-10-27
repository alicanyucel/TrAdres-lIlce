using TrAdresılIlce.Application.Features.Auth.Login;
using TrAdresılIlce.Domain.Entities;

namespace TrAdresılIlce.Application.Services
{
    public interface IJwtProvider
    {
        Task<LoginCommandResponse> CreateToken(AppUser user);
    }
}
