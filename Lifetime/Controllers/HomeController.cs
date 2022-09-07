using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Lifetime.Interfaces;
using Lifetime.Models;

namespace Lifetime.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private ISingletonService _singletonService;
        private IScopedService _scopedService;
        private ITransientService _transientService;

        public HomeController(ILogger<HomeController> logger,
            ISingletonService singletonService,
            IScopedService scopedService,
            ITransientService transientService)
        {
            _logger = logger;
            _singletonService = singletonService;
            _scopedService = scopedService;
            _transientService = transientService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Singleton()
        {
            return View(_singletonService.GetRandomNumber());
        }

        public IActionResult Scoped()
        {
            return View(_scopedService.GetRandomNumber());
        }

        public IActionResult Transient()
        {
            return View(_transientService.GetRandomNumber());
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}