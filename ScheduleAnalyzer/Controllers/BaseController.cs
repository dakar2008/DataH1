using Microsoft.AspNetCore.Mvc;
using ScheduleAnalyzer.Data;

namespace ScheduleAnalyzer.Controllers
{
    public abstract class BaseController<T> : Controller where T : BaseController<T>
    {
        private IWebHostEnvironment _env;

        protected ApplicationDbContext Db => (ApplicationDbContext)HttpContext.RequestServices.GetService(typeof(ApplicationDbContext));
        protected IWebHostEnvironment WebHost => _env ?? (_env = HttpContext?.RequestServices.GetService<IWebHostEnvironment>());
    }
}