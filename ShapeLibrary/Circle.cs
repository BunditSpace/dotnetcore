using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeLibrary
{
    class Circle : IShape
    {
        private double Redius;

        public Circle(double redius)
        {
            this.Redius = redius;
        }

        public double GetArea()
        {
            return Math.PI * Math.Pow(Redius, 2);
        }

        public double GetPerimeter()
        {
            return 2 * Math.PI * Redius;
        }
    }
}
