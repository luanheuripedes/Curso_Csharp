using System;

namespace _9_Estrutura_condicional
{
    class Program
    {
        static void Main(string[] args)
        {
            // if ---- if else ------ if elseif

            //Estrutura condicional composta
            /*
            Console.WriteLine("Entre com um numero inteiro");
            int x = int.Parse(Console.ReadLine());

            if(x % 2 == 0)
            {
                Console.WriteLine("Numero par");
            }
            else
            {
                Console.WriteLine("Impar");
            }
            */

            //Estrutura encadeada
            Console.WriteLine("Digite a hora atual");
            int hora = int.Parse(Console.ReadLine());

            if(hora < 12)
            {
                Console.WriteLine("Bom dia!");
            }else if (hora >= 12 && hora < 18)
            {
                Console.WriteLine("Boa tarde!");
            }
            else
            {
                Console.WriteLine("Boa noite !");
            }

        }
    }
}
