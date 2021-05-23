using System;

namespace URI_1164
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, x, a, b;

            n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                x = int.Parse(Console.ReadLine());

                a = x / 2;
                b = 0;

                for(int j = 1; j <= a; j++)
                {
                    if(x % j == 0)
                        b += j;
                }
                if(b == x)
                {
                    Console.WriteLine($"{x} eh perfeito");
                }
                else
                {
                    Console.WriteLine($"{x} nao eh perfeito");
                }

            }
        }
    }
}