using System;

namespace URI_1165
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int x, cont;
            for (int i = 0; i < n; i++)
            {
                cont = 0;
                x = int.Parse(Console.ReadLine());
                for (int j = 2; j < x; j++)
                {
                    if (x % j == 0)
                    {
                        cont++;
                    }
                }
                if (cont == 0)
                {
                    Console.WriteLine($"{x} eh primo");
                }

                else
                {
                    Console.WriteLine($"{x} nao eh primo");
                }
            }
        }
    }
}
