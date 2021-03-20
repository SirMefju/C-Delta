using System;

namespace Delta
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Gimme 'a'");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Gimme 'b'");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Gimme 'c'");
            double c = Convert.ToDouble(Console.ReadLine());
            double delta = b * b - 4 * a * c;
            Console.WriteLine("Delta = " + delta);
            double elementDelta = Math.Pow(delta, 0.5);
            Console.WriteLine("Element of delta = " + elementDelta);
            if (delta > 0)
            {
                double xi = ((-b - elementDelta) / 2 * a);
                double xii = ((-b + elementDelta) / 2 * a);
                Console.WriteLine("Solution I = " + xi);
                Console.WriteLine("Solution II = " + xii);
            }
            else if (delta == 0)
            {
                double xo = -b / (2 * a);
                Console.WriteLine("Because Delta = 0, u have only one solution = " + xo);
            }
            else
                Console.WriteLine("You don't have real solutions.");
        }
    }
}
