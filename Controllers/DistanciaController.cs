using IntroduccionCsharp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IntroduccionCsharp.Controllers
{
    public class DistanciaController : Controller
    {
        // GET: Distancia
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult Distancia(Distancia modelo)
        {
            modelo.CalcularDistancia();
            return View(modelo);
        }


    }
}