using System;

namespace URI_1059
{
    class Program
    {
        /*
        Faça um programa que mostre os números pares entre 1 e 100, inclusive.
        Entrada: Neste problema extremamente simples de repetição não há entrada.
        Saída: Imprima todos os números pares entre 1 e 100, inclusive se for o caso, um em cada linha.
        Exemplo de Entrada 	Exemplo de Saída
	                        2
                            4
                            6
                            ...
                            100 
         */

        static void Main( string[] args )
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
