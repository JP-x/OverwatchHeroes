using OverwatchHeroes.Data;
using OverwatchHeroes.Models;
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
        public ActionResult Details(string name)
        {
            var Heroes = HeroesRepo.GetHeroes();
            Hero herotodisplay = null;
            foreach(var hero in Heroes)
            {
                if(name == hero.Name)
                {
                    //match found break out of loop
                    herotodisplay = hero;
                    break;
                }
                else
                {
                    //prevent invalid heroes from being passed in
                    //default to genji
                    if(hero.Name == "Genji")
                    {
                        herotodisplay = hero;
                    }
                }
            }
            
            return View(herotodisplay);
        }
    }
}