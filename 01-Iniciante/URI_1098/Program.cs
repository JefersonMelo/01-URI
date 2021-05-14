using System;
using System.Globalization;

namespace URI_1098
{
    class Program
    {
        static void Main(string[] args)
        {
            double i, j, value;
            int temp, temp2;

            for ( i = 0, j = 1, value = 0, temp = 0, temp2 = 0; i < 2.1; j++ )
            {
                if ( temp2 == 0 )
                {
                    Console.WriteLine($"I={i.ToString("F0", CultureInfo.InvariantCulture)} J={j.ToString("F0", CultureInfo.InvariantCulture)}");
                }
                else
                {
                    Console.WriteLine($"I={i.ToString("F1", CultureInfo.InvariantCulture)} J={j.ToString("F1", CultureInfo.InvariantCulture)}");
                }

                temp++;

                if ( temp == 3 )
                {
                    i += 0.2;
                    value += 0.2;
                    j = value;
                    temp = 0;
                    temp2++;
                }
                if ( temp2 == 5 )
                {
                    temp2 = 0;
                }

            }
        }
    }
}
