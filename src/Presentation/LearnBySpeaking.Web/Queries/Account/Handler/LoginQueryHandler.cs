using LearnBySpeaking.Web.Models;
using LearnBySpeaking.Web.Queries.Account.Model;
using MediatR;
using Microsoft.AspNetCore.Identity;
using System.Threading;
using System.Threading.Tasks;

namespace LearnBySpeaking.Web.Queries.Account.Handler
{
    public class LoginQueryHandler : IRequestHandler<LoginQuery, LearnBySpeakingResult>
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;

        public LoginQueryHandler(
            UserManager<IdentityUser> userManager,
            SignInManager<IdentityUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public async Task<LearnBySpeakingResult> Handle(LoginQuery request, CancellationToken cancellationToken)
        {
            var user = await _userManager.FindByNameAsync(request.Username);

            if (user is null || !await _userManager.CheckPasswordAsync(user, request.Password))
            {
                return LearnBySpeakingResult.ErrorResult("Kullanıcı adı veya Parola hatalı");
            }

            await _signInManager.SignInAsync(user, true);

            return LearnBySpeakingResult.Successful;
        }
    }
}