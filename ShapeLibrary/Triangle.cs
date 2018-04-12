using System;

namespace ShapeLibrary
{
    public class Triangle : IShape
    {
        private double Height;
        private double Width;

        public Triangle(double height, double width)
        {
            this.Height = height;
            this.Width = width;
        }

        public double GetArea()
        {
            return 0.5 * Height * Width;
        }

        public double GetPerimeter()
        {
            return Height * Width * Math.Sqrt(Math.Pow(Height, 2) + Math.Pow(Width, 2));
        }
    }
}
