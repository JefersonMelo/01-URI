using System;

namespace URI_1065
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[5];
            int cont = 0;
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
                if (array[i] % 2 == 0)
                {
                    cont++;
                }
            }
            Console.WriteLine($"{cont} valores pares");
        }
    }
}
