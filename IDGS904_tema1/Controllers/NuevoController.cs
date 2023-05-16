using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IDGS904_tema1.Controllers
{
    public class NuevoController : Controller
    {
        public ActionResult NuevaVistaIndex()
        {
            ViewBag.NuevaVista = "Hola Nueva Vista";
            return View();
        }

        public ActionResult Vista(string n1, string n2)
        {
            int res = Convert.ToInt32(n1) + Convert.ToInt32(n2);
            ViewBag.Res = Convert.ToString(res);

            return View();
        }
    }
}