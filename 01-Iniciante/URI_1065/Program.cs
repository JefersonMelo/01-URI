using System;

namespace URI_1065
{
    class Program
    {
        /*
        Faça um programa que leia 5 valores inteiros. Conte quantos destes valores digitados são pares e mostre esta informação.
        Entrada: O arquivo de entrada contém 5 valores inteiros quaisquer.
        Saída: Imprima a mensagem conforme o exemplo fornecido, indicando a quantidade de valores pares lidos.
        Exemplo de Entrada 	Exemplo de Saída
        7                   3 valores pares
        -5
        6
        -4
        12
         */

        static void Main( string[] args )
        {
            int[] array = new int[5];
            int cont = 0;
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
                if (array[i] % 2 == 0)
                {
                    cont++;
                }
            }
            Console.WriteLine($"{cont} valores pares");
        }
    }
}
