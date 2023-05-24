using IDGS904_tema1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IDGS904_tema1.Controllers
{
    public class TienditaController : Controller
    {
        // GET: Tiendita
        public ActionResult Index()
        {
            var alumno = new Alumno()
            {
                nombre = "Ivan",
                edad = 20,
                estaActivo = true,
                inscripcion = new DateTime(2023, 1, 1)
            };
            ViewBag.alumno = alumno;
            return View();
        }

        // GET: Tiendita/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Tiendita/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Tiendita/Create
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

        // GET: Tiendita/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Tiendita/Edit/5
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

        // GET: Tiendita/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        public ActionResult Registrar()
        {
            return View();
        }
        public ActionResult CalcularTemperatura()
        {
            
            return View();
        }
        public ActionResult CalcularTemperaturaResultado(ConvertidorGrados cg)
        {
            cg.getResult();
            TempData["result"] = cg.result;
            return View();
        }

        // POST: Tiendita/Delete/5
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
