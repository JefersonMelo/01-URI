using System;

namespace URI_1097
{
    class Program
    {
        /*
        Você deve fazer um programa que apresente a sequencia conforme o exemplo abaixo.
        Entrada: Não há nenhuma entrada neste problema.
        Saída: Imprima a sequencia conforme exemplo abaixo.
        Exemplo de Entrada 	Exemplo de Saída
                            I=1 J=7
                            I=1 J=6
                            I=1 J=5
                            I=3 J=9
                            I=3 J=8
                            I=3 J=7

                            ...
                            I=9 J=15
                            I=9 J=14
                            I=9 J=13 
         */

        static void Main( string[] args )
        {
            int i = 1, j = 7, k = 0;
            while (i < 10)
            {
                Console.WriteLine($"I={i} J={j}");
                j--;
                k++;
                if (k == 3)
                {
                    j += 5;
                    k = 0;
                    i += 2;
                }
            }
        }
    }
}
