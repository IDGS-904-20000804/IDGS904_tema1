using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Web;

namespace IDGS904_tema1.Models
{
    public class Triangle
    {
        public double p1x { get; set; }
        public double p1y { get; set; }
        public double p2x { get; set; }
        public double p2y { get; set; }
        public double p3x { get; set; }
        public double p3y { get; set; }
        public double area { get; set; }
        public string type { get; set; }
        
        public bool isTriangle()
        {
            double point1x = this.p1x;
            double point1y = this.p1y;
            double point2x = this.p2x;
            double point2y = this.p2y;
            double point3x = this.p3x;
            double point3y = this.p3y;
            double distancep1p2 = Math.Sqrt(Math.Pow((point2x - point1x), 2) + Math.Pow((point2y - point1y), 2));
            double distancep2p3 = Math.Sqrt(Math.Pow((point3x - point2x), 2) + Math.Pow((point3y - point2y), 2));
            double distancep3p1 = Math.Sqrt(Math.Pow((point3x - point1x), 2) + Math.Pow((point3y - point1y), 2));
            double smallest = 0;
            double middle = 0;
            double largest = 0;
            if (
                (point1x == point2x) && (point1y == point2y) ||
                (point2x == point3x) && (point2y == point3y) ||
                (point1x == point3x) && (point1y == point3y)
            )
            {
                return false;
            }
            if (distancep1p2 <= distancep2p3 && distancep1p2 <= distancep3p1)
            {
                smallest = distancep1p2;
                if (distancep2p3 <= distancep3p1)
                {
                    middle = distancep2p3;
                    largest = distancep3p1;
                }
                else
                {
                    middle = distancep3p1;
                    largest = distancep2p3;
                }
            }
            else if (distancep2p3 <= distancep1p2 && distancep2p3 <= distancep3p1)
            {
                smallest = distancep2p3;
                if (distancep1p2 <= distancep3p1)
                {
                    middle = distancep1p2;
                    largest = distancep3p1;
                }
                else
                {
                    middle = distancep3p1;
                    largest = distancep1p2;
                }
            }
            else
            {
                smallest = distancep3p1;
                if (distancep1p2 <= distancep2p3)
                {
                    middle = distancep1p2;
                    largest = distancep2p3;
                }
                else
                {
                    middle = distancep2p3;
                    largest = distancep1p2;
                }
            }
            if ((largest < (smallest + middle)))
            {
                return true;
            }
            return false;
        }

        public void calculateArea()
        {
            double ax = this.p1x;
            double ay = this.p1y;
            double bx = this.p2x;
            double by = this.p2y;
            double cx = this.p3x;
            double cy = this.p3y;
            double a = Math.Sqrt(Math.Pow(bx - ax, 2) + Math.Pow(by - ay, 2));
            double b = Math.Sqrt(Math.Pow(cx - bx, 2) + Math.Pow(cy - by, 2));
            double c = Math.Sqrt(Math.Pow(ax - cx, 2) + Math.Pow(ay - cy, 2));
            double s = (a + b + c) / 2;
            this.area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
        }

        public void typeTriangle()
        {
            double point1x = this.p1x;
            double point1y = this.p1y;
            double point2x = this.p2x;
            double point2y = this.p2y;
            double point3x = this.p3x;
            double point3y = this.p3y;
            double distancep1p2 = Math.Round(Math.Sqrt(Math.Pow((point2x - point1x), 2) + Math.Pow((point2y - point1y), 2)), 1);
            double distancep2p3 = Math.Round(Math.Sqrt(Math.Pow((point3x - point2x), 2) + Math.Pow((point3y - point2y), 2)), 1);
            double distancep3p1 = Math.Round(Math.Sqrt(Math.Pow((point3x - point1x), 2) + Math.Pow((point3y - point1y), 2)), 1);
            if ((distancep1p2 == distancep2p3) && (distancep1p2 == distancep3p1) && (distancep2p3 == distancep3p1))
            {
                this.type = "Equilátelo";
                return;
            }
            else if ((distancep1p2 == distancep2p3) || (distancep1p2 == distancep3p1) || (distancep2p3 == distancep3p1))
            {
                this.type = "Isóseles";
                return;
            }
            else
            {
                this.type = "Escaleno";
                return;
            }
        }

    }
}