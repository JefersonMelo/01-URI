using System;
using System.Globalization;
namespace URI_1079
{
    class Program
    {
        /*
        Leia 1 valor inteiro N, que representa o número de casos de teste que vem a seguir. 
        Cada caso de teste consiste de 3 valores reais, cada um deles com uma casa decimal. 
        Apresente a média ponderada para cada um destes conjuntos de 3 valores, sendo que o
        primeiro valor tem peso 2, o segundo valor tem peso 3 e o terceiro valor tem peso 5.
        Entrada: O arquivo de entrada contém um valor inteiro N na primeira linha. Cada N 
        linha a seguir contém um caso de teste com três valores com uma casa decimal cada valor.
        Saída: Para cada caso de teste, imprima a média ponderada dos 3 valores, conforme exemplo abaixo.
        Exemplo de Entrada 	Exemplo de Saída
        3
        6.5 4.3 6.2         5.7
        5.1 4.2 8.1         6.3
        8.0 9.0 10.0        9.3 
         */

        static void Main( string[] args )
        {
            double n1, n2, n3;
            int x = int.Parse(Console.ReadLine());

            for (int i = 0; i < x; i++)
            {
                string[] vet = Console.ReadLine().Split(' ');
                n1 = double.Parse(vet[0], CultureInfo.InvariantCulture);
                n2 = double.Parse(vet[1], CultureInfo.InvariantCulture);
                n3 = double.Parse(vet[2], CultureInfo.InvariantCulture);
                Console.WriteLine((((n1 * 2.0) + (n2 * 3.0) + (n3 * 5.0)) / 10.0).ToString("F1", CultureInfo.InvariantCulture));
            }
        }
    }
}
