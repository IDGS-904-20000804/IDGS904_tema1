using IDGS904_tema1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IDGS904_tema1.Services
{
    public class ProductoServices
    {
        public List<Producto> ObtenerProducto()
        {
            var producto1 = new Producto()
            {
                nombre = "Puelque",
                descripcion = "Frutos rojos",
                cantidad = 10,
                produccion = new DateTime(2023, 11, 5)
            };
            var producto2 = new Producto()
            {
                nombre = "Puelque2",
                descripcion = "Mango Piña",
                cantidad = 35,
                produccion = new DateTime(2023, 6, 10)
            };
            return new List<Producto> { producto1, producto2 };
        }
    }
}