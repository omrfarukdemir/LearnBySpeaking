using LearnBySpeaking.Web.Models.ViewModels.Account;
using LearnBySpeaking.Web.Queries.Account.Model;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace LearnBySpeaking.Web.Controllers
{
    
    public class AccountController : BaseController
    {
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View("Login", model);
            }

            var result = await Mediator.Value.Send(Mapper.Value.Map<LoginQuery>(model));

            if (!result.Success)
            {
                AddErrorModelState(result.ErrorMessages.ToList());

                return View("Login", model);
            }

            return RedirectToAction("Index", "Exam");
        }
    }
}