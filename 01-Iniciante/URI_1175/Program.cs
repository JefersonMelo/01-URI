using System;

namespace uri_1175
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vet = new int[20];

            for (int i = 0; i < vet.Length; i++)
            {
                vet[i] = int.Parse(Console.ReadLine());
            }
            Array.Reverse(vet);
            for (int i = 0; i < vet.Length; i++)
            {
                System.Console.WriteLine($"N[{i}] = {vet[i]}");
            }
        }
    }
}
