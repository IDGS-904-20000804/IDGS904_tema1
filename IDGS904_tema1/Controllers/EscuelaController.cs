using IDGS904_tema1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IDGS904_tema1.Controllers
{
    public class EscuelaController : Controller
    {
        // GET: Escuela
        // public ActionResult Index()
        // {
        //     return View();
        // }

        // public ContentResult Index()
        // {
        //     return Content("<h1>Hola<br>Ivan</h1>");
        // }

        // public ViewResult Index()
        // {
        //     return View("<h1>Hola<br>Ivan</h1>");
        // }

        public JsonResult Index()
        {
            var pulque = new Producto()
            {
                nombre = "pulque1",
                descripcion = "fresa",
                cantidad = 10,
                produccion = new DateTime(2023, 11, 2)
            };
            return Json(pulque, JsonRequestBehavior.AllowGet);
        }


        public RedirectResult Vista()
        {
            return Redirect("https://google.com.mx");
        }

        public RedirectToRouteResult Vista2(Distancia objDistancia)
        {
            objDistancia.calcularDistancia();
            TempData["objDistancia"] = objDistancia;
            return RedirectToAction("Resultado", "Escuela");
            // TempData["nombre"] = "Ivan";
            // return RedirectToAction("Index", "Home");
        }
        public ActionResult Resultado()
        {
            Distancia objDistancia = new Distancia();
            if (TempData.ContainsKey("objDistancia"))
            {
                objDistancia = TempData["objDistancia"] as Distancia;
            }
            ViewBag.resultado = objDistancia.resultado;
            return View();
        }

        public ActionResult Index2()
        {
            ViewBag.Grupo = "IDGS904";
            ViewData["Materia"] = "Desarrollo Web Integral";
            string nombre = "";
            Distancia objDistancia = new Distancia();
            if (TempData.ContainsKey("nombre"))
            {
                nombre = TempData["nombre"] as string;
            }
            if (TempData.ContainsKey("objDistancia"))
            {
                objDistancia = TempData["objDistancia"] as Distancia;
                objDistancia.calcularDistancia();
            }
            ViewBag.resultado = objDistancia.resultado;
            ViewBag.valor = nombre;
            return View();
        }


        // GET: Escuela/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Escuela/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Escuela/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Escuela/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Escuela/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Escuela/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Escuela/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
