using Microsoft.AspNetCore.Mvc;
using ScheduleAnalyzer.Data;

namespace ScheduleAnalyzer.Controllers
{
    public abstract class BaseController<T> : Controller where T : BaseController<T>
    {
        private ILogger<T> _logger;
        private IWebHostEnvironment _environment;

        protected ApplicationDbContext db => (ApplicationDbContext)HttpContext.RequestServices.GetService(typeof(ApplicationDbContext));
        protected ILogger<T> Logger => _logger ?? (_logger = HttpContext?.RequestServices.GetService<ILogger<T>>());
        protected IWebHostEnvironment webHost => _environment ?? (_environment = HttpContext?.RequestServices.GetService<IWebHostEnvironment>());
    }
}