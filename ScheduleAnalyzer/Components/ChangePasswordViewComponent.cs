using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ScheduleAnalyzer.Data;
using ScheduleAnalyzer.Models;
using ScheduleAnalyzer.Models.SA_Models.ViewModels;

namespace ScheduleAnalyzer.Components
{
    public class ChangePasswordViewComponent : ViewComponent
    {
        protected ApplicationDbContext db => (ApplicationDbContext)HttpContext.RequestServices.GetService(typeof(ApplicationDbContext));

        public IViewComponentResult Invoke()
        {
            ChangePassViewModel vm = new ChangePassViewModel();
            vm.User = db.Users.FirstOrDefault(m => m.Email == User.Identity.Name) as ApplicationUser;
            return View(vm);
        }
    }
}