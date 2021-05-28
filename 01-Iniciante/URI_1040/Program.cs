using System;
using System.Globalization;

namespace URI_1040
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double d = double.Parse(Console.ReadLine());

            double media = ((a * 2) + (b * 3) + (c * 4) + (d * 1)) / 10;
            Console.WriteLine($"Media: {media.ToString("F1", CultureInfo.InvariantCulture)}");

            if (media >= 7)
            {
                Console.WriteLine("Aluno aprovado.");
            }
            else if (media >= 5 && media < 7)
            {
                Console.WriteLine("Aluno em exame.");
                double n5 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine($"Nota do exame: {n5.ToString(CultureInfo.InvariantCulture)}");
                media = (media + n5) / 2;

                if (media >= 5)
                {
                    Console.WriteLine("Aluno aprovado.");
                }
                else
                {
                    Console.WriteLine("Aluno reprovado.");
                }
                Console.WriteLine($"Media final: {media.ToString("F1", CultureInfo.InvariantCulture)}");
            }
            else
            {
                Console.WriteLine("Aluno aprovado.");
            }
        }
    }
}
