using LifeTimeOFDI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace LifeTimeOFDI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ISingletonGuid singleton;
        private readonly ITransientGuid transient;
        private readonly IScopedGuid scoped;
        private readonly GuidService guidService;

        public HomeController(ILogger<HomeController> logger, ISingletonGuid singleton, ITransientGuid transient, IScopedGuid scoped, GuidService guidService)
        {
            _logger = logger;
            this.singleton = singleton;
            this.transient = transient;
            this.scoped = scoped;
            this.guidService = guidService;
        }

        public IActionResult Index()
        {
            ViewBag.Singleton = singleton.Guid.ToString();
            ViewBag.Transient = transient.Guid.ToString();
            ViewBag.Scoped = scoped.Guid.ToString();

            ViewBag.ServiceSingleton = guidService.SingletonGuid.Guid.ToString();
            ViewBag.ServiceTransient = guidService.TransientGuid.Guid.ToString();
            ViewBag.ServiceScoped = guidService.ScopedGuid.Guid.ToString();


            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
