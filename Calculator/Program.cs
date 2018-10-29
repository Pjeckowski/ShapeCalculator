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
                Console.WriteLine("2: Okrąg");

                Console.WriteLine("0: Zakończ");


                Console.Write("\n Wybór:");

                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        {
                            shape = new Square();
                            break;
                        }
                    case 2:
                        {
                            shape = new Circle();
                            break;
                        }
                    default:
                        {
                            continue;
                        }
                }

                double area = calculator.CalculateArea(shape);
                Console.WriteLine($"Pole wynosi: {area}");
                Console.WriteLine("Nacisnij dowolny przycisk aby kontynuować.");
                Console.ReadKey();
                Console.Clear();

            } while (choice != 0);

            Console.WriteLine("Zakonczono!");
            Thread.Sleep(2000);
        }
    }
}
