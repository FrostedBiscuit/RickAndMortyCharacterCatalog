using System.Diagnostics;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CharacterCatalog.Models;
using CharacterCatalog.Web.Services.Interfaces;

namespace CharacterCatalog.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly ICharacterService _characterService;

        public HomeController(ILogger<HomeController> logger, ICharacterService characterService)
        {
            _logger = logger;
            _characterService = characterService;
        }

        public async Task<IActionResult> Index([FromQuery] int page = 0, [FromQuery] int pageSize = 20)
        {
            return View(await _characterService.GetAsync(page, pageSize));
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
