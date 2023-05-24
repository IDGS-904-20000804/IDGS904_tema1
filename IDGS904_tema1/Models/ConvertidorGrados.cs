using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IDGS904_tema1.Models
{
    public class ConvertidorGrados
    {
        public double value { get; set; }
        public int opc { get; set; }
        public double result { get; set; }
        public void getResult()
        {
            if (opc == 1)
            {
                // GET celsius
                // this.result = celsius
                // this.value = fahrenheit

                this.result = ((1 / 1.8) * (this.value - 32));
            }
            if (opc == 2)
            {
                // GET fahrenheit
                // this.result = fahrenheit
                // this.value = celsius
                this.result = ((this.value) * (1.8)) + 32;
            }
        }
    }
}