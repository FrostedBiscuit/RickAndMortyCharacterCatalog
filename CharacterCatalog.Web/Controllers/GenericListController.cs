using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CharacterCatalog.Web.Controllers
{
    public class GenericListController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
