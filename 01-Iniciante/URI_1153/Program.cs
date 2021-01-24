using System;

namespace URI_1153
{
    class Program
    {
        /*
        Ler um valor N. Calcular e escrever seu respectivo fatorial. Fatorial de N = N * (N-1) * (N-2) * (N-3) * ... * 1.
        Entrada: A entrada contém um valor inteiro N (0 < N < 13).
        Saída: A saída contém um valor inteiro, correspondente ao fatorial de N.
        Exemplo de Entrada 	Exemplo de Saída
        4                   24
         */

        static void Main( string[] args )
        {
            int aux = 1;
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < (n - 1); i++)
            {
                aux *= n - i;
            }
            Console.WriteLine(aux);
        }
    }
}
