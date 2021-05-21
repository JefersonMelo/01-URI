using System;

namespace URI_1154
{
    class Program
    {
        static void Main(string[] args)
        {
            int cont = 0;
            float media, soma = 0;

            int num = int.Parse(Console.ReadLine());

            while ( num >= 0 )
            {
                cont++;
                soma += num;

                num = int.Parse(Console.ReadLine());
            }
            media = soma / cont;
            Console.WriteLine($"{media:F2}");
        }
    }
}
