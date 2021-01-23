using System;
using System.Globalization;

namespace URI_1010
{
    class Program
    {
        /*
        Neste problema, deve-se ler o código de uma peça 1, o número de peças 1, o valor unitário de cada peça 1, o código de uma peça 2, 
        o número de peças 2 e o valor unitário de cada peça 2. Após, calcule e mostre o valor a ser pago.
        Entrada: O arquivo de entrada contém duas linhas de dados. Em cada linha haverá 3 valores, respectivamente dois inteiros e um valor 
        com 2 casas decimais.
        Saída: A saída deverá ser uma mensagem conforme o exemplo fornecido abaixo, lembrando de deixar um espaço após os dois pontos e um 
        espaço após o "R$". O valor deverá ser apresentado com 2 casas após o ponto.
        Exemplos de Entrada 	Exemplos de Saída
        12 1 5.30               VALOR A PAGAR: R$ 15.50
        16 2 5.10
	
        13 2 15.30              VALOR A PAGAR: R$ 51.40
        161 4 5.20
         */

        static void Main( string[] args )
        {
            int A, B, D, E;
            double C, F;
            string[] s = Console.ReadLine().Split(' ');
            string[] ss = Console.ReadLine().Split(' ');
            A = int.Parse(s[0]);
            B = int.Parse(s[1]);
            C = double.Parse(s[2], CultureInfo.InvariantCulture);
            D = int.Parse(ss[0]);
            E = int.Parse(ss[1]);
            F = double.Parse(ss[2], CultureInfo.InvariantCulture);
            double resultado = (B * C) + (E * F);
            Console.WriteLine($"VALOR A PAGAR: R$ {resultado.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
