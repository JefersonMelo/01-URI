using System;

namespace URI_2702
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] entrada_A = Console.ReadLine().Split();
            int Ca = int.Parse(entrada_A[0]);
            int Ba = int.Parse(entrada_A[1]);
            int Pa = int.Parse(entrada_A[2]);
            string[] entrada_B = Console.ReadLine().Split();
            int Cr = int.Parse(entrada_B[0]);
            int Br = int.Parse(entrada_B[1]);
            int Pr = int.Parse(entrada_B[2]);

            int semComida = 0;

            if ( Cr > Ca ) semComida += Cr - Ca;
            if ( Br > Ba ) semComida += Br - Ba;
            if ( Pr > Pa ) semComida += Pr - Pa;

            Console.WriteLine(semComida);
        }
    }
}
