using System;

namespace URI_1026
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, r;
            string[] s = Console.ReadLine().Split(' ');
            while ( s.Length > 1 )
            {

                x = int.Parse(s[0]);
                y = int.Parse(s[1]);
                r = x ^ y;
                Console.WriteLine(r);

                s = Console.ReadLine().Split(' ');
            }
        }
    }
}
