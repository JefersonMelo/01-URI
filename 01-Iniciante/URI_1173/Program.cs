using System;

namespace URI_1173
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = new int[10];
            int v = int.Parse(Console.ReadLine());

            for(int i = 0; i < n.Length; i++)
            {
                n[i] = v;
                Console.WriteLine($"N[{i}] = {n[i]}");
                v *= 2;
            }
        }
    }
}
