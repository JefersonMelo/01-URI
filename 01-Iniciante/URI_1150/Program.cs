using System;

namespace URI_1150
{
    class Program
    {
        static void Main(string[] args)
        {
            int R = int.Parse(Console.ReadLine());
            int V = 0;
            int b = 0;
            int c = 0;

            do
            {
                V = int.Parse(Console.ReadLine());

            } while ( R >= V );

            do
            {
                b += R;
                c++;
                R++;
            } while ( b <= V );

            Console.WriteLine(c);
        }
    }
}
