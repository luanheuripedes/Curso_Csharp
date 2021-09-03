using System;

namespace clezieu_array
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //int n1, n2, n3, n4, n5;
            int[] n = new int[5];
            //int[] num = new int[3]{55,89,65};
            int[] num = { 55, 89, 65 };

            n[0] = 5;
            n[1] = 5;
            n[2] = 5;
            n[3] = 5;
            Console.WriteLine(num[2]);
            */

            //Iteração com for e foreach
            int[] n = new int[5];

            //FOR
            /*
            for (int i =0;i < n.Length;i++)
            {
                Console.WriteLine($"Digite um numero: {i+1}");
                n[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < n.Length; i++)
            {
                Console.WriteLine(n[i]);
            }
            */
            //foreach
    

            foreach (int elemento in n)
            {
                Console.WriteLine(elemento);
                
            }
        }
    }
}
