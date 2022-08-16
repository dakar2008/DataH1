using Microsoft.AspNetCore.Mvc;
using ScheduleAnalyzer.Models;

namespace ScheduleAnalyzer.Controllers
{
    public class AccountController : BaseController<AccountController>
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginViewModel model)
        {
            return View();
        }
    }
}