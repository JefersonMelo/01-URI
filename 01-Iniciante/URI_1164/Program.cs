using System;

namespace URI_1164
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, x, a, b, c, d;

            n = int.Parse(Console.ReadLine());

            for(a = 1; a <= n; a++)
            {
                x = int.Parse(Console.ReadLine());

                c = x / 2;
                d = 0;

                for(b = 1; b <= c; b++)
                {
                    if(x % b == 0)
                        d += b;
                }
                if(d == x)
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