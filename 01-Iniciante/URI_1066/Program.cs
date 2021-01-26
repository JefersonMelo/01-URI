using System;

namespace URI_1066
{
    class Program
    {
        /*
        Leia 5 valores Inteiros. A seguir mostre quantos valores digitados foram pares, quantos valores digitados foram ímpares, 
        quantos valores digitados foram positivos e quantos valores digitados foram negativos.
        Entrada: O arquivo de entrada contém 5 valores inteiros quaisquer.
        Saída: Imprima a mensagem conforme o exemplo fornecido, uma mensagem por linha, não esquecendo o final de linha após cada uma.
        Exemplo de Entrada 	Exemplo de Saída
        -5                  3 valor(es) par(es)
        0                   2 valor(es) impar(es)
        -3                  1 valor(es) positivo(s)
        -4                  3 valor(es) negativo(s)
        12
         */

        static void Main( string[] args )
        {
            int[] array = new int[5];
            int par = 0,
                impar = 0,
                positivo = 0,
                negativo = 0;
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
                if (array[i] % 2 == 0)
                {
                    par++;
                }
                if (array[i] % 2 != 0)
                {
                    impar++;
                }
                if (array[i] > 0)
                {
                    positivo++;
                }
                if (array[i] < 0)
                {
                    negativo++;
                }

            }
            Console.WriteLine($"{par} valor(es) par(es)\n" +
                            $"{impar} valor(es) impar(es)\n" +
                            $"{positivo} valor(es) positivo(s)\n" +
                            $"{negativo} valor(es) negativo(s)");
        }
    }
}
