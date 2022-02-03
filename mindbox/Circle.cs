using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mindbox
{
    class Circle : Figure
    {
        /// <summary>
        /// Радиус треугольника
        /// </summary>
        public double Radius { get; set; }

        public Circle(double radius)
        {
            if (radius < 0)
            {
                throw new ArgumentException("Радиус должен быть положительным числом.");
            }
            else
            {
                Radius = radius;
            }
        }
        public override double GetArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}
