using System;

namespace URI_1156
{
    class Program
    {
        static void Main(string[] args)
        {
            float s = 1;

            int x = 2;

            for ( int i = 3; i <= 39; i+=2 )
            {
                s += ( float )i / ( float )x;
                
                x *= 2;
            }
            Console.WriteLine($"{s:F2}");
        }
    }
}
