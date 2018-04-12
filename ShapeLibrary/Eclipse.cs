using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeLibrary
{
    class Eclipse : IShape
    {
        private double RediusX;
        private double RediusY;

        public Eclipse(double rediusX, double rediusY)
        {
            this.RediusX = rediusX;
            this.RediusY = rediusY;
        }

        public double GetArea()
        {
            return Math.PI * RediusX * RediusY;
        }

        public double GetPerimeter()
        {
            return Math.PI * (RediusX + RediusY);
        }
    }
}
