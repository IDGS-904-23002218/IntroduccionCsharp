using IntroduccionCsharp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IntroduccionCsharp.Controllers
{
    public class MultiplicacionController : Controller
    {
        // GET: Multiplicacion
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Multiplicar(Multiplicacion modelo)
        {
            modelo.CalcularMultiplicacion();
            return View(modelo);
        }
    }
}