using System;

namespace URI_1172
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vet = new int[10];
            int i;

            for(i = 0; i < vet.Length; i++)
            {
                int x = int.Parse(Console.ReadLine());

                if(x <= 0)
                {
                    vet[i] = 1;
                }
                else
                {
                    vet[i] = x;
                }
            }
            for(i = 0; i < vet.Length; i++)
            {
                Console.WriteLine($"X[{i}] = {vet[i]}");
            }
        }
    }
}
