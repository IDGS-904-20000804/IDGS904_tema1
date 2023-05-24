using IDGS904_tema1.Models;
using IDGS904_tema1.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IDGS904_tema1.Controllers
{
    public class TraductorController : Controller
    {
        // GET: Traductor
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Translate()
        {
            var translate = TempData["translation"];
            ViewBag.translate = translate;
            return View();
        }

        [HttpPost]
        public ActionResult Translate(Traductor t)
        {
            var arch = new LeerService();
            var translation = arch.SearchTranslation(t.value.ToLower(), t.opc);
            if (translation != null)
            {
                TempData["translation"] = translation;
            }
            return RedirectToAction("Translate");
        }

        public ActionResult Registrar()
        {
            var arch = new LeerService();
            ViewBag.mostrarDatos = TempData["mostrarDatos"];
            ViewBag.table = arch.readTranslate();
            return View();
        }

        [HttpPost]
        public ActionResult Registrar(Traductor t)
        {
            var ope1 = new GuardarService();
            ope1.saveTranslate(t);
            return RedirectToAction("Registrar");
        }
        [HttpPost]
        public ActionResult ShowTable()
        {
            TempData["mostrarDatos"] = 1;
            return RedirectToAction("Registrar");
        }
        [HttpPost]
        public ActionResult HideTable()
        {
            TempData["mostrarDatos"] = null;
            return RedirectToAction("Registrar");
        }
        


        // GET: Traductor/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Traductor/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Traductor/Create
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

        // GET: Traductor/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Traductor/Edit/5
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

        // GET: Traductor/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Traductor/Delete/5
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
