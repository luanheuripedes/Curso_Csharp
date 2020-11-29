 using System;
using System.Globalization;

namespace SaidaDeDadosCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            char genero = 'F';
            int idade = 32;
            double saldo = 10.35784;
            string nome = "Maria";

            Console.Write("boa noite");
            Console.WriteLine("bom dia");
            Console.WriteLine("Boa tarde!");

            Console.WriteLine("----------------------");
            Console.WriteLine(genero);
            Console.WriteLine(idade);
            Console.WriteLine(saldo);
            Console.WriteLine(nome);
            Console.WriteLine(saldo.ToString("F2"));
            Console.WriteLine(saldo.ToString("F4"));
            Console.WriteLine(saldo.ToString("F4",CultureInfo.InvariantCulture));
            */

            /*
            int idade = 32;
            double saldo = 10.35784;
            string nome = "Maria";

            //Playceholders
            Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2:f2} reais",nome, idade, saldo);

            //Interpolação
            Console.WriteLine($"{nome} tem {idade} anos e tem saldo igual a {saldo:f2} reais");

            //Concatenação
            Console.WriteLine(nome + " tem " + idade + " e tem saldo igual a " + saldo.ToString("F2", CultureInfo.InvariantCulture) + " reais ");
            */

            //Exercicio
            string produto1 = "Computador";
            string produto2 = "Mesa de escritório";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;

            Console.Write("Produtos:");
            Console.WriteLine($"{produto1}, cujo o preço é ${preco1:f2}");
            Console.WriteLine($"{produto2}, cujo preço é ${preco2:f2}");
            Console.WriteLine($"Registro: {idade} anos de idade, código {codigo} e genero: {genero}");
        }   
    }
}
