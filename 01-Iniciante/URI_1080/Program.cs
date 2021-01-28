using System;

namespace URI_1080
{
    class Program
    {
        /*
        Leia 100 valores inteiros. Apresente então o maior valor lido e a posição dentre os 100 valores lidos.
        Entrada O arquivo de entrada contém 100 números inteiros, positivos e distintos.
        Saída Apresente o maior valor lido e a posição de entrada, conforme exemplo abaixo.
        Exemplo de Entrada 	Exemplo de Saída
        2                   34565
        113                 4 
        45
        34565
        6
        ...
        8
         */

        static void Main( string[] args )
        {
            int[] n = new int[100];
            int maior, pos = 0;
            for (int i = 0; i < n.Length; i++)
            {
                n[i] = int.Parse(Console.ReadLine());
            }
            maior = n[0];
            for (int i = 0; i < n.Length; i++)
            {
                if (n[i] > maior)
                {
                    maior = n[i];
                    pos = i + 1;
                }
            }
            Console.WriteLine(maior);
            Console.WriteLine(pos);
        }
    }
}
