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
            /*
            double pi = 3.14159f,raio,area;

            Console.WriteLine("Digite o raio do circulo:");
            raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            area = Math.Pow(raio,2.0) * pi;

            Console.WriteLine($"A={area.ToString("F4",CultureInfo.InvariantCulture)}");
            */

            //Ex3
            /*
            int a, b, c, d,diferenca;

            Console.WriteLine("Digite 4 valores inteiros");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            d = int.Parse(Console.ReadLine());

            diferenca = (a * b - c * d);

            Console.WriteLine($"{diferenca}");
            */

            //Ex4
            /*
            int number,hours;
            float hoursalary, salary;

            Console.WriteLine("Digite seu numero");
            number = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor que vc recebe por horas:");
            hoursalary = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Digite o numero de horas trabalhadas");
            hours = int.Parse(Console.ReadLine());

            salary = hoursalary * hours;

            Console.WriteLine($"Number={hours}");
            Console.WriteLine($"Salary={salary.ToString("F2", CultureInfo.InvariantCulture)}");
            */

            //Ex5
            float valor;
            Console.WriteLine("Peça 1");
            string[] vet1 = Console.ReadLine().Split(' ');
            int c1 = int.Parse(vet1[0]);
            int n1 = int.Parse(vet1[1]);
            float p1 = float.Parse(vet1[2], CultureInfo.InvariantCulture);

            Console.WriteLine("Peça 2");
            string[] vet2 = Console.ReadLine().Split(' ');
            int c2 = int.Parse(vet2[0]);
            int n2 = int.Parse(vet2[1]);
            float p2 = float.Parse(vet2[2],CultureInfo.InvariantCulture);

            valor = n1*p1 + n2*p2;

            Console.WriteLine($"Valor a pagar: R${valor.ToString("f2",CultureInfo.InvariantCulture)}");
        }
    }
}
