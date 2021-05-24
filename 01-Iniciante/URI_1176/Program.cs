using System;

namespace URI_1176
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double fibonacci = 1.0, seqFib = 0.0;
            

            for(int i = 0; i < n; i++)
            {
                int a = int.Parse(Console.ReadLine());

                for(int j = 1; j < a; j++)
                {
                    fibonacci += seqFib;
                    seqFib = fibonacci - seqFib;
                }

                if(a == 0) fibonacci = 0;

                Console.WriteLine($"Fib({a}) = {fibonacci}");
                fibonacci = 1.0;
                seqFib = 0.0;
            }
        }
    }
}
