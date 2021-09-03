using System;

namespace removendoelementovetor
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] v = new int[10];
            int tl = 0; 

            v[0] = 35;
            v[1] = 42;
            v[2] = 38;
            v[3] = 789;
            v[4] = 654;
            

            foreach(int elemento in v)
            {
                Console.WriteLine(elemento);
            }

        }
    }
}
