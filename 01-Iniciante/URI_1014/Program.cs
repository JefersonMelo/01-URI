using System;
using System.Globalization;

namespace URI_1014
{
    class Program
    {
        static void Main(string[] args)
        {
            double Y, KML;
            int X;
            X = int.Parse(Console.ReadLine());
            Y = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            KML = X / Y;

            Console.WriteLine(KML.ToString("F3", CultureInfo.InvariantCulture) + " km/l");
        }
    }
}
