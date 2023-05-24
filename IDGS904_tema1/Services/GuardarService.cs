
using IDGS904_tema1.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace IDGS904_tema1.Services
{
    public class GuardarService
    {
        public void guardarArchivo(Maestro m)
        {
            var nombre = m.nombre;
            var aPaterno = m.aPaterno;
            var aMaterno = m.aMaterno;
            var edad = m.edad;
            var email = m.email;
            var datos = nombre + "," + aPaterno + "," + aMaterno + "," + edad + "," + email
                + Environment.NewLine;
            var archivo = HttpContext.Current.Server.MapPath("~/App_Data/datos.txt");
            // File.WriteAllText(archivo, datos);
            File.AppendAllText(archivo, datos);
        }
        public void saveTranslate(Traductor t)
        {
            var spanish = t.spanish.ToLower();
            var english = t.english.ToLower();
            var datos = spanish + "," + english + Environment.NewLine;
            var archivo = HttpContext.Current.Server.MapPath("~/App_Data/traductor.txt");
            File.AppendAllText(archivo, datos);
        }

    }
}