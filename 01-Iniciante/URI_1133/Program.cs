using System;

namespace URI_1133
{
    class Program
    {
        /*
        Escreva um programa que leia 2 valores X e Y e que imprima todos os valores entre eles cujo resto da divisão dele por 5 for igual a 2 ou igual a 3.
        Entrada: O arquivo de entrada contém 2 valores positivos inteiros quaisquer, não necessariamente em ordem crescente.
        Saída: Imprima todos os valores conforme exemplo abaixo, sempre em ordem crescente.
        Sample Input 	Sample Output
        10              12
        18              13
	                    17
         */

        static void Main( string[] args )
        {
            int x, y, aux;
            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());

            if (x < y)
            {
                aux = y;
                y = x;
                x = aux;
            }
            while (x >= y)
            {
                
                if (y % 5 == 2 || y % 5 == 3)
                {
                    Console.WriteLine(y);
                }
                y++;
            }
        }
    }
}
