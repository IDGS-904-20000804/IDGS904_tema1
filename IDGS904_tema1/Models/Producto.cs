using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IDGS904_tema1.Models
{
    public class Producto
    {
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public int cantidad { get; set; }
        public DateTime produccion { get; set; }
    }
}