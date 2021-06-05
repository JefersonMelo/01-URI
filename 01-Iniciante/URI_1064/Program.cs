using System;
using System.Globalization;

namespace URI_1064
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] array = new double[6];
            double soma = 0.0;
            int cont = 0;

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (array[i] > 0)
                {
                    cont++;
                    soma += array[i];
                }
            }
            Console.WriteLine($"{cont} valores positivos");
            soma /= cont;
            Console.WriteLine(soma.ToString("F1", CultureInfo.InvariantCulture));
        }
    }
}
