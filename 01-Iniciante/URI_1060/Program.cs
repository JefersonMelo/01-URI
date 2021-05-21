using System;

namespace URI_1060
{
    class Program
    {
        static void Main(string[] args)
        {
            int cont = 0;
            for (int i = 0; i < 6; i++)
            {
                double x = double.Parse(Console.ReadLine());
                if (x > 0)
                {
                    cont++;
                }
            }
            Console.WriteLine($"{cont} valores positivos");
        }
    }
}
