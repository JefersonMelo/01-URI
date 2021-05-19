using System;
using System.Globalization;

namespace URI_1160
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());
            int pa, pb;
            double cpa, cpb;
            int anos;

            for ( int i = 0; i < t; i++ )
            {
                anos = 0;
                string[] valores = Console.ReadLine().Split(' ');
                pa = int.Parse(valores[0]);
                pb = int.Parse(valores[1]);

                cpa = double.Parse(valores[2], CultureInfo.InvariantCulture);
                cpb = double.Parse(valores[3], CultureInfo.InvariantCulture);

                while ( pa <= pb )
                {
                    pa = (int)(pa * ( 1.0 + cpa / 100 ));
                    pb = (int)(pb * ( 1.0 + cpb / 100 ));
                    anos++;

                    if ( anos > 100 )
                    {
                        break;
                    }
                }

                if ( anos <= 100 )
                {
                    Console.WriteLine($"{anos} anos.");
                }
                else
                {
                    Console.WriteLine("Mais de 1 seculo.");
                }
            }
        }
    }
}
