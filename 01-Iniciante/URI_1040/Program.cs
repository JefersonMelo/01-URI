using System;
using System.Globalization;

namespace URI_1040
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, d, n5, media;

            string[] s = Console.ReadLine().Split(' ');
            a = double.Parse(s[0], CultureInfo.InvariantCulture);
            b = double.Parse(s[1], CultureInfo.InvariantCulture);
            c = double.Parse(s[2], CultureInfo.InvariantCulture);
            d = double.Parse(s[3], CultureInfo.InvariantCulture);

            media = (a * 2.0 + b * 3.0 + c * 4.0 + d * 1.0) / 10.0;
            Console.WriteLine($"Media: {media.ToString("F1", CultureInfo.InvariantCulture)}");

            if (media >= 7.0)
            {
                Console.WriteLine("Aluno aprovado.");
            }
            else if (media >= 5.0)
            {
                Console.WriteLine("Aluno em exame.");
                n5 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine($"Nota do exame: {n5.ToString("F1", CultureInfo.InvariantCulture)}");

                if ((media + n5) / 2.0 > 5.0)
                {
                    Console.WriteLine("Aluno aprovado.");
                }
                else
                {
                    Console.WriteLine("Aluno reprovado.");
                }
                media = (media + n5) / 2.0;
                Console.WriteLine($"Media final: {media.ToString("F1", CultureInfo.InvariantCulture)}");
            }
            else
            {
                Console.WriteLine("Aluno reprovado.");
            }
        }
    }
}
