using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeLibrary
{
    public class Rectangle : IShape
    {
        private double Height;
        private double Width;

        public Rectangle(double height, double width)
        {
            this.Height = height;
            this.Width = width;
        }

        public double GetArea()
        {
            return Height * Width;
        }

        public double GetPerimeter()
        {
            return (Height + Width) * 2;
        }
    }
}
