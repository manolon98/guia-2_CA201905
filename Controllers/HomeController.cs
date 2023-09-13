using MvcMusicStoreDos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcMusicStoreDos.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            //Lista de generos
            var genres = new List<Genre>
            {
                new Genre {Name = "Disco"},
                new Genre {Name = "Jazz"},
                new Genre {Name = "Rock"}
            };

            return View(genres);
        }
       /*public String Index()
       {
           return "Hello from home";
       }*/
    }
}