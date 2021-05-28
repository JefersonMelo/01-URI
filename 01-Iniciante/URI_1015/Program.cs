using System;
using System.Globalization;

namespace URI_1015
{
    class Program
    {
        static void Main(string[] args)
        {

            double x1, y1, x2, y2;
            string[] s = Console.ReadLine().Split(' ');
            string[] ss = Console.ReadLine().Split(' ');
            x1 = double.Parse(s[0], CultureInfo.InvariantCulture);
            y1 = double.Parse(s[1], CultureInfo.InvariantCulture);
            x2 = double.Parse(ss[0], CultureInfo.InvariantCulture);
            y2 = double.Parse(ss[1], CultureInfo.InvariantCulture);

            Console.WriteLine(Math.Sqrt(Math.Pow(x2 - x1, 2.0) + Math.Pow(y2 - y1, 2.0)).ToString("F4"));

        }
    }
}
