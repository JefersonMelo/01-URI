using System;
using System.Globalization;

namespace URI_1038
{
    class Program
    {
        static void Main(string[] args)
        {
            double hotDog = 4.00,
                   xSalada = 4.50,
                   xBacon = 5.00,
                   torrada = 2.00,
                   refri = 1.50,
                   total = 0;
            string[] s = Console.ReadLine().Split(' ');
            int cod, qtd;
            cod = int.Parse(s[0]);
            qtd = int.Parse(s[1]);
            switch (cod)
            {
                case 1:
                    total = hotDog * qtd;
                    break;
                case 2:
                    total = xSalada * qtd;
                    break;
                case 3:
                    total = xBacon * qtd;
                    break;
                case 4:
                    total = torrada * qtd;
                    break;
                case 5:
                    total = refri * qtd;
                    break;
                default:
                    Console.WriteLine("Default case");
                    break;
            }
            Console.WriteLine($"Total: R$ {total.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
