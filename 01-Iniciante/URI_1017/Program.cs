using System;

namespace URI_1017
{
    class Program
    {
        static void Main(string[] args)
        {
            int t, v;
            double g;
            t = int.Parse(Console.ReadLine());
            v = int.Parse(Console.ReadLine());
            g = t * v / 12.0;
            Console.WriteLine(g.ToString("F3"));
        }
    }
}
