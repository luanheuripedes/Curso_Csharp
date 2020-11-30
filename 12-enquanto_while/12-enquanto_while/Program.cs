using System;
using System.Globalization;

namespace _12_enquanto_while
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um numero");
            double x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            while (x >= 0.0)
            {
                double raiz = Math.Sqrt(x);
                Console.WriteLine(raiz.ToString("f3", CultureInfo.InvariantCulture));
                Console.Write("Digite outro número ");
                x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            
        }
    }
}
