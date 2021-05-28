using System;

namespace URI_1020
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, d, m, a;
            n = int.Parse(Console.ReadLine());
            a = n / 365;
            m = (n % 365) / 30;
            d = (n % 365) % 30;
            Console.WriteLine(a + " ano(s)\n" + m + " mes(es)\n" + d + " dia(s)");
        }
    }
}
