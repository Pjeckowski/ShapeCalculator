using System;

namespace Calculator
{
    public class Square : IShape
    {
        private double _a;

        public Square(double a)
        {
            _a = a;
        }

        public Square()
        {
            Console.WriteLine("Podaj bok a:");
            _a = Convert.ToInt32(Console.ReadLine());
        }

        public double CalculateArea()
        {
            return _a * _a;
        }
    }
}
