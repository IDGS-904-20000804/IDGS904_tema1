using IDGS904_tema1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IDGS904_tema1.Controllers
{
    public class TriangleController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult TriangleArea()
        {
            return View();
        }
        [HttpPost]
        public ActionResult TriangleArea(Triangle t)
        {
            if (t.isTriangle())
            {
                t.calculateArea();
                t.typeTriangle();
                ViewBag.area = t.area;
                ViewBag.type = t.type;
            } else
            {
                ViewBag.type = "No es un triangulo";
            }
            return View();
        }
    }
}