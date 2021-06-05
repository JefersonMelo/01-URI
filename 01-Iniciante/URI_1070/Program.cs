using System;

namespace URI_1070
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, cont = 0;
            n = int.Parse(Console.ReadLine());

            if (n % 2 == 0) { n++; }

            while (cont < 6)
            {
                Console.WriteLine(n);
                cont++;
                n += 2;
            }
        }
    }
}
