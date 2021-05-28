using System;
using System.Globalization;

namespace URI_1010
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B, D, E;
            double C, F;
            string[] s = Console.ReadLine().Split(' ');
            string[] ss = Console.ReadLine().Split(' ');
            A = int.Parse(s[0]);
            B = int.Parse(s[1]);
            C = double.Parse(s[2], CultureInfo.InvariantCulture);
            D = int.Parse(ss[0]);
            E = int.Parse(ss[1]);
            F = double.Parse(ss[2], CultureInfo.InvariantCulture);
            double resultado = (B * C) + (E * F);
            Console.WriteLine($"VALOR A PAGAR: R$ {resultado.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
