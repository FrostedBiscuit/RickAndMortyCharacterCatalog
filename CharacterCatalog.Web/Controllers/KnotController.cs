using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
