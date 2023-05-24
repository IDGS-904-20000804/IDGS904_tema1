using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IDGS904_tema1.Models
{
    public class Alumno
    {
        public string nombre { get; set; }
        public int edad { get; set; }
        public bool estaActivo { get; set; }
        public DateTime inscripcion { get; set; }

    }
}