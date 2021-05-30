using System;

namespace URI_1044
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split(' ');
            int a, b;
            a = int.Parse(s[0]);
            b = int.Parse(s[1]);
            if (b % a == 0 || a % b == 0)
            {
                Console.WriteLine("Sao Multiplos");
            }
            else
            {
                Console.WriteLine("Nao sao Multiplos");
            }
        }
    }
}
