using System;
using System.Globalization;

namespace Exercicios_pt1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //Ex1
            Console.WriteLine("Digite o primeiro valor");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor");
            int b = int.Parse(Console.ReadLine());

            int soma = a + b;

            Console.WriteLine($"Soma:{soma}");
            */

            //Ex2

            double pi = 3.14159f,raio,area;

            Console.WriteLine("Digite o raio do circulo:");
            raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            area = Math.Pow(raio,2.0) * pi;

            Console.WriteLine($"A={area.ToString("F4",CultureInfo.InvariantCulture)}");

        }
    }
}
