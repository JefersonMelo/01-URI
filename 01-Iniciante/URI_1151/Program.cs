using System;

namespace URI_1151
{
    class Program
    {
        static void Main(string[] args)
        {
            int n,
                numFib = 1,
                num = 0;

            n = int.Parse(Console.ReadLine());

            Console.Write($"{0} {1}");
            while ( n > 2 )
            {
                numFib += num;
                num = numFib - num;
                Console.Write($" {numFib}");
                n--;
            }
        }
    }
}

