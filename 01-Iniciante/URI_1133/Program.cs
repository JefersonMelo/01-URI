using System;

namespace URI_1133
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, aux;
            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());

            if ( x < y )
            {
                aux = y;
                y = x;
                x = aux;
            }
            for ( int i = (y + 1); i < x; i++ )
            {
                if ( i % 5 == 2 || i % 5 == 3 )
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}

