using System;

namespace URI_1002
{
    class Program
    {
        static void Main(string[] args)
        {
            double N = 3.14159;
            double A, R;

            R = double.Parse(Console.ReadLine());

            A = N * (R * R);

            Console.WriteLine("A=" + A.ToString("F4"));
        }
    }
}
