using System;

namespace Calculator
{
    public class Circle : IShape
    {
        private double _radius;

        public Circle(double radius)
        {
            _radius = radius;
        }

        public Circle()
        {
            Console.WriteLine("GIB ME RADIUS!!!!");
            _radius = Convert.ToDouble(Console.ReadLine());
        }

        public double CalculateArea()
        {
            return 2 * Math.PI * _radius;
        }
    }
}
