using System;
using System.Globalization;

namespace URI_1043
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split(' ');
            double a, b, c, result = 0;
            a = double.Parse(s[0]);
            b = double.Parse(s[1]);
            c = double.Parse(s[2]);
            if (a < (b + c) && b < (a + c) && c < (a + b))
            {
                result = a + b + c;
                Console.WriteLine($"Perimetro = {result.ToString("F1", CultureInfo.InvariantCulture)}");
            }
            else
            {
                result = (a + b) * c / 2.0;
                Console.WriteLine($"Area = {result.ToString("F1", CultureInfo.InvariantCulture)}");
            }
        }
    }
}
