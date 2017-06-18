using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OverwatchHeroes.Controllers
{
    public class ErrorController : Controller
    {
        // GET: PageNotFound
        [HandleError]
        public ActionResult PageNotFound()
        {
            Response.StatusCode = 404;
            Response.TrySkipIisCustomErrors = true;
            return View("PageNotFound");
        }
    }
}