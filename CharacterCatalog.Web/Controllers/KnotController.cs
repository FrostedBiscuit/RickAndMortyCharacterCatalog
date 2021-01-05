using Microsoft.AspNetCore.Mvc;

namespace CharacterCatalog.Web.Controllers
{
    public class KnotController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
