using System;

namespace URI_1071
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, aux, soma = 0;
            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());

            if (x < y)
            {
                aux = x;
                x = y;
                y = aux;
            }
            if (y < 0)
            {
                y++;
            }

            while (x > y)
            {
                if (y % 2 != 0)
                {
                    soma += y;
                }
                y++;
            }
            Console.WriteLine(soma);
        }
    }
}
