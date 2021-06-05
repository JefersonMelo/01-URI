using System;

namespace URI_1066
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[5];

            int par = 0,
                impar = 0,
                positivo = 0,
                negativo = 0;

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());

                if (array[i] % 2 == 0) { par++; }
                if (array[i] % 2 != 0) { impar++; }
                if (array[i] > 0) { positivo++; }
                if (array[i] < 0) { negativo++; }
            }
            Console.WriteLine($"{par} valor(es) par(es)\n" +
                            $"{impar} valor(es) impar(es)\n" +
                            $"{positivo} valor(es) positivo(s)\n" +
                            $"{negativo} valor(es) negativo(s)");
        }
    }
}
