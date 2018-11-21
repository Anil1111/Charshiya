using Charshiya.Data.DbModels;
using Charshiya.Models.Account;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Charshiya.Controllers
{
    public class AccountController : Controller
    {
        private SignInManager<CharshiyaUser> signInManager;

        public AccountController(SignInManager<CharshiyaUser> signInManager)
        {
            this.signInManager = signInManager;
        }

        public IActionResult Register()
        {
            return this.View();
        }

        [HttpPost]
        public IActionResult Register(RegisterUserInputModel registerModel)
        {
            return this.View();
        }
    }
}