using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
/*Agregamos el modelo*/
using MvcMusicStoreDos.Models;

namespace MvcMusicStoreDos.Controllers
{
    public class StoreController : Controller
    {
        // GET: Store
        /*public String Index()
        {
            return "Hello from Store.index()";
        }*/
        public ActionResult Browse(String genre)
        {
            /*String message = HttpUtility.HtmlEncode("Store.Browse, Genre= " + genre);
            return message;*/
            var genreModel = new Genre { Name = genre };
            return View(genreModel);
        }
        // GET: /Store/Details/5
        public ActionResult Details(int id)
        {
            var album =  new Album { Title = "Album " + id };
            return View(album);
        }
    }
}