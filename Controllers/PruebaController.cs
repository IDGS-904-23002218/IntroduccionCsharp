using IntroduccionCsharp.Models;
using IntroduccionCsharp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IntroduccionCsharp.Controllers
{
    public class PruebaController : Controller
    {
        // GET: Prueba
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Suma()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Suma(string x, string y, string r1)
        {
            int res = Convert.ToInt16(x) + Convert.ToInt16(y);
            ViewBag.Res = Convert.ToString(res);

            return View();
        }

        public ActionResult Calculos(OperasBas ap)
        {
            ap.Suma();
            return View(ap);
        }

        public ActionResult MuestraPeliculas()
        {
            var peliculasServices = new PeliculasService();
            var model = peliculasServices.ObtenerPelicula();

            return View(model);
        }
    }
}