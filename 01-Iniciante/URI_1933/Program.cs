using System;

namespace URI_1933
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            
            string[] vet = Console.ReadLine().Split(' ');
            a = int.Parse(vet[0]);
            b = int.Parse(vet[1]);

            while (a > 0 && b > 0)
            {
                if (a == b)
                {
                    Console.WriteLine(a);
                    break;
                }
                else if (a > b)
                {
                    Console.WriteLine(a);
                    break;
                }
                else if (a < b)
                {
                    Console.WriteLine(b);
                    break;
                }

            }
        }
    }
}
