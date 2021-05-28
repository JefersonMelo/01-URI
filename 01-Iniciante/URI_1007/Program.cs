using System;

namespace URI_1007
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, B, C, D, DIFERENCA;

            A = int.Parse(Console.ReadLine());
            B = int.Parse(Console.ReadLine());
            C = int.Parse(Console.ReadLine());
            D = int.Parse(Console.ReadLine());

            DIFERENCA = (A * B) - (C * D);

            Console.WriteLine("DIFERENCA = " + DIFERENCA);
        }
    }
}
