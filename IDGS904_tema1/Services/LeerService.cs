using IDGS904_tema1.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace IDGS904_tema1.Services
{
    public class LeerService
    {
        public Array leerArchivo()
        {
            Array datos = null;
            var inforMaes = HttpContext.Current.Server.MapPath("~/App_Data/datos.txt");
            if (File.Exists(inforMaes))
            {
                datos = File.ReadAllLines(inforMaes);
            }
            return datos;
        }

        public string[] readTranslate()
        {
            string[] datos = null;
            var infor = HttpContext.Current.Server.MapPath("~/App_Data/traductor.txt");
            if (File.Exists(infor))
            {
                datos = File.ReadAllLines(infor);
            }
            return datos;
        }

        public string SearchTranslation(string searchValue, int option)
        {
            var arr = readTranslate();
            if (arr != null)
            {
                foreach (var line in arr)
                {
                    var splitValues = line.Split(',');
                    if ((splitValues[0] == searchValue) || (splitValues[1] == searchValue))
                    {
                        return splitValues[option];
                    }
                }
            }
            return null;
        }

    }
}