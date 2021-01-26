using System;
using System.Globalization;

namespace URI_1064
{
    class Program
    {
        /*
        Leia 6 valores. Em seguida, mostre quantos destes valores digitados foram positivos. Na próxima linha, deve-se mostrar a 
        média de todos os valores positivos digitados, com um dígito após o ponto decimal.
        Entrada: A entrada contém 6 números que podem ser valores inteiros ou de ponto flutuante. Pelo menos um destes números será positivo.
        Saída: O primeiro valor de saída é a quantidade de valores positivos. A próxima linha deve mostrar a média dos valores positivos digitados.
        Exemplo de Entrada 	Exemplo de Saída
        7                   4 valores positivos
        -5                  7.4 
        6
        -3.4
        4.6
        12
         */

        static void Main( string[] args )
        {
            double[] array = new double[6];
            double soma = 0.0;
            int cont = 0;

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (array[i] > 0)
                {
                    cont++;
                    soma += array[i];
                }
            }
            Console.WriteLine($"{cont} valores positivos");
            soma /= cont;
            Console.WriteLine(soma.ToString("F1", CultureInfo.InvariantCulture));
        }
    }
}
