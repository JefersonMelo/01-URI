using System;

namespace URI_1132
{
    class Program
    {
        /*
        Escreva um algoritmo que leia 2 valores inteiros X e Y calcule a soma dos números que não são múltiplos de 13 entre X e Y, incluindo ambos.
        Entrada: O arquivo de entrada contém 2 valores inteiros quaisquer, não necessariamente em ordem crescente.
        Saída: Imprima a soma de todos os valores não divisíveis por 13 entre os dois valores lidos na entrada, inclusive ambos se for o caso.
        Sample Input 	Sample Output
        100             13954
        200
         */

        static void Main( string[] args )
        {
            int x, y, soma = 0, aux;
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
                if (x % 13 != 0)
                {
                    soma += x;                    
                }
                x--;
            }          
            Console.WriteLine(soma);
        }
    }
}
