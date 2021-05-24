using System;
using System.Globalization;

namespace URI_1174
{
    class Program
    {
        static void Main(string[] args)
        {

            double[] array = new double[100];
            //leitira de dados
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = double.Parse(Console.ReadLine());
            }
            //imprimir array
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] <= 10)
                {
                    System.Console.WriteLine($"A[{i}] = {array[i].ToString("F1", CultureInfo.InvariantCulture)}");
                }
            }
        }
    }
}
