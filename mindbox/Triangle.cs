using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mindbox
{
    class Triangle : Figure
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }
        public bool IsRightTriangle 
        {
            get 
            {
                double[] sides = { A, B, C };
                Array.Sort(sides);
                return Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2) == Math.Pow(sides[2], 2);
            }
        }

        public Triangle(double a, double b, double c)
        {
            if ((a + b) > c || (a + c) > b || (b + c) > a)
            {
                throw new ArgumentException("Фигура не является треугольником.");
            }

            else if (a <= 0 || b <= 0 || c <= 0)
            {
                throw new ArgumentException("Одна из сторон меньше нуля.");
            }

            else
            {
               A = a;
               B = b;
               C = c;
            }
        }

        public override double GetArea()
        {
            // Полупериметр  треугольника.
            double p = (A + B + C) / 2;

            return Math.Sqrt(p * ((p - A) * (p - B) * (p - C)));
        }
    }
}
