using System;

namespace URI_1145
{
    class Program
    {
        /*
        Escreva um programa que leia dois valores X e Y. A seguir, mostre uma sequência de 1 até Y, passando para a próxima linha a cada X números.
        Entrada: O arquivo de entrada contém dois valores inteiros, (1 < X < 20) e (X < Y < 100000).
        Saída: Cada sequência deve ser impressa em uma linha apenas, com 1 espaço em branco entre cada número, 
        conforme exemplo abaixo. Não deve haver espaço em branco após o último valor da linha.
        Exemplo de Entrada 	Exemplo de Saída
        3 99                1 2 3
                            4 5 6
                            7 8 9
                            10 11 12
                            ...
                            97 98 99
         */

        static void Main( string[] args )
        {
            int x, y, cont = 0;
            string[] vet = Console.ReadLine().Split(' ');
            x = int.Parse(vet[0]);
            y = int.Parse(vet[1]);

            if (1 < x && x < 20 && (y < 100000))
            {
                for (int i = 1; i <= y; i++)
                {
                    cont++;
                    if (cont == x)
                    {
                        Console.Write($"{i}\n");
                        cont = 0;
                    }
                    else
                    {
                        Console.Write($"{i} ");
                    }
                }
            }
        }
    }
}
