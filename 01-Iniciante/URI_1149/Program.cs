using System;

namespace URI_1149
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, n = 0, b = 0;

            string[] line = Console.ReadLine().Split(' ');
            x = int.Parse(line[0]);

            for ( int i = 0; i < line.Length; i++ )
            {
                if ( int.Parse(line[i]) > 0 )
                {
                    n = int.Parse(line[i]);
                }
            }

            for ( int i = 0; i < n; i++ )
            {
                b += x;
                x++;
            }
            Console.WriteLine(b);
        }
    }
}
