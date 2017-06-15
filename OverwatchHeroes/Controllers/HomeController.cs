using OverwatchHeroes.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OverwatchHeroes.Controllers
{
    public class HomeController : Controller
    {
        private HeroRepository HeroesRepo = null;
        public HomeController()
        {
            //initialize heroes list
            HeroesRepo = new HeroRepository();
        }

        public ActionResult Index()
        {
            //get hero list from repo
            var Heroes = HeroesRepo.GetHeroes();
            return View(Heroes);
        }

        //pass in a hero to display all relevant information
        public ActionResult Details()
        {
            
            return View();
        }
    }
}