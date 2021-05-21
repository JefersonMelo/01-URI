using System;
using System.Globalization;

namespace URI_1051
{
    class Program
    {
        static void Main(string[] args)
        {
            double v, imp = 0.0, r08, r18, r28, isento = 2000.0;
            v = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (v < isento)
            {
                Console.WriteLine("Isento");
            }
            else
            {
                if (v <= 3000.0)//8%
                {
                    v -= isento;
                    imp = v * 0.08;

                }
                else if (v > 3000.0 && v <= 4500.0)//18%
                {
                    v -= isento;
                    r18 = v - 1000.0;
                    r08 = v - r18;
                    imp = r08 * 0.08 + (r18 * 0.18);
                }
                else if (v > 4500.0)//28%
                {
                    r08 = 1000.0;
                    r18 = 1500.0;
                    v -= r08 + r18;
                    r28 = v - isento;
                    imp = (r08 * 0.08) + (r18 * 0.18) + (r28 * 0.28);

                }
                Console.WriteLine($"R$ {imp.ToString("F2", CultureInfo.InvariantCulture)}");
            }
        }
    }
}
