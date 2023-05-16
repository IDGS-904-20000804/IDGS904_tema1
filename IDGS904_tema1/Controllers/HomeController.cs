using IDGS904_tema1.Models;
using IDGS904_tema1.Services;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Services.Description;

namespace IDGS904_tema1.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Saludo()
        {
            ViewBag.Saludo = "Hola Mundo!";
            return View();
        }
        public ActionResult Calcular(OperasBas op)
        {
            var model = new OperasBas();
            model.calcular();
            return View(model);
        }
        public ActionResult MostrarPulques()
        {
            var pulques = new ProductoServices();
            var model = pulques.ObtenerProducto();
            return View(model);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            ViewBag.Materia = " DWI";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}