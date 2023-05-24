using IDGS904_tema1.Models;
using IDGS904_tema1.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IDGS904_tema1.Controllers
{
    public class ArchivoController : Controller
    {
        // GET: Archivo
        public ActionResult Registrar()
        {

            return View();
        }
        [HttpPost]
        public ActionResult Registrar(Maestro m)
        {
            var ope1 = new GuardarService();
            ope1.guardarArchivo(m);
            return View();
        }
        public ActionResult LeerDatos()
        {
            var arch = new LeerService();
            ViewBag.Archivo = arch.leerArchivo();
            return View();
        }

    }
}