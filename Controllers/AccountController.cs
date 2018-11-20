using Charshiya.Data.DbModels;
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
    }
}