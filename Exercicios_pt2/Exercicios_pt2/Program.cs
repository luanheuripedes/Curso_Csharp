using System;

namespace Exercicios_pt2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ex1
            /*
            int number = int.Parse(Console.ReadLine());

            if(number >= 0)
            {
                Console.WriteLine("Não negativo");
            }
            else
            {
                Console.WriteLine("Negativo");
            }
            */

            //Ex2
            /*
            int number = int.Parse(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine("PAR");
            }
            else
            {
                Console.WriteLine("IMPAR");
            }
            */

            //ex3
            /*
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            if(a % b == 0)
            {
                Console.WriteLine("São Multiplos");
            }
            else
            {
                Console.WriteLine("Não são multiplos");
            }
            */

            //Ex4
            /*
            string[] horas = Console.ReadLine().Split(' ');
            int hInicial = int.Parse(horas[0]);
            int hFinal = int.Parse(horas[1]);

            int duracao;

            if(hInicial < hFinal)
            {
                duracao = hFinal - hInicial;
            }
            else
            {
                duracao = 24 - hInicial + hFinal;
            }
            Console.WriteLine($"o JOGO DUROU: {duracao}");
            */
        }
    }
}
