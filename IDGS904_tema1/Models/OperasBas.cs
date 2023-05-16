using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IDGS904_tema1.Models
{
    public class OperasBas
    {
        public double num1 { get; set; }
        public double num2 { get; set; }
        public double res { get; set; }
        public int operacion { get; set; }

        public double sumar() { return this.num1 + this.num2; }
        public double restar() { return this.num1 - this.num2; }
        public double dividir() {
            if (this.num2 != 0)
            {
                return this.num1 / this.num2;
            }
            else
            {
                return 0;
            }
        }
        public double multiplicar() { return this.num1 * this.num2; }

        public void calcular()
        {
            switch (this.operacion)
            {
                case 1:
                    this.res = sumar();
                    break;
                case 2:
                    this.res = restar();
                    break;
                case 3:
                    this.res = multiplicar();
                    break;
                case 4:
                    this.res = dividir();
                    break;
                default:
                    this.res = 0;
                    break;
            }
        }
    }
}