using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OverwatchHeroes.Controllers
{
    public class PageNotFoundController : Controller
    {
        // GET: PageNotFound
        public ActionResult PageNotFound()
        {
            return View();
        }
    }
}