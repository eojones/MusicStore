using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MusicStore.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
   
        public ActionResult Profile()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Pesquisa_Album()
        {
            return View();
        }

    
        public ActionResult Cadastra_Album()
        {
            return View();
        }

        public ActionResult ErrorPage()
        {
            return View();
        }
    }
}