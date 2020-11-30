using System;
using System.Globalization;

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

            //ex5
            string[] produto = Console.ReadLine().Split(' ');
            int codigo = int.Parse(produto[0]);
            int qtd = int.Parse(produto[1]);
            float valorFinal = 0.00f;

            if(codigo == 1)
            {
                float preco = 4.00f;
                valorFinal = (float)preco * qtd;
            }else if(codigo == 2)
            {
                float preco = 4.50f;
                valorFinal = (float)preco * qtd;
            }
            else if(codigo == 3)
            {
                float preco = 5.00f;
                valorFinal = (float)preco * qtd;
            }
            else if (codigo == 4)
            {
                float preco = 2.00f;
                valorFinal = (float)preco * qtd;
            }
            else if(codigo == 5)
            {
                float preco = 1.50f;
                valorFinal = (float)preco * qtd;
            }

            Console.WriteLine($"Total: {valorFinal.ToString("f2", CultureInfo.InvariantCulture)}");

        }
    }
}
