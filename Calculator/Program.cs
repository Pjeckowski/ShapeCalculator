using System;
using System.Threading;

namespace Calculator
{
    class Program
    {
       
        static void Main(string[] args)
        {
            IShapeCalculator calculator = new Calculator();
            IShape shape = new Square(5);

            int choice = 0;

            do
            {
                Console.WriteLine("Wybierz kształt:");

                Console.WriteLine("1: Kwadrat");

                Console.Write("\n Wybór:");

                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        {
                            shape = new Square();
                            break;
                        }
                    default:
                        {
                            continue;
                        }
                }

                double area = calculator.CalculateArea(shape);
                Console.WriteLine($"Pole wynosi: {area}");
            } while (choice != 0);

            Console.WriteLine("Zakonczono!");
            Thread.Sleep(2000);
        }
    }
}
