using System;

namespace URI_1099
{
    class Program
    {
        /*
        Leia um valor inteiro N que é a quantidade de casos de teste que vem a seguir. Cada caso de teste consiste de dois inteiros X e Y. 
        Você deve apresentar a soma de todos os ímpares existentes entre X e Y.
        Entrada: A primeira linha de entrada é um inteiro N que é a quantidade de casos de teste que vem a seguir. 
        Cada caso de teste consiste em uma linha contendo dois inteiros X e Y.
        Saída: Imprima a soma de todos valores ímpares entre X e Y.
        Exemplo de Entrada 	Exemplo de Saída
        7
        4 5                 0
        13 10               11
        6 4                 5
        3 3                 0
        3 5                 0
        3 4                 0
        3 8	                12
         */

        static void Main( string[] args )
        {
            int n, x, y, aux, soma;

            n = int.Parse(Console.ReadLine());

            while (n > 0)
            {
                string[] s = Console.ReadLine().Split(' ');
                x = int.Parse(s[0]);
                y = int.Parse(s[1]);
                if (x < y)
                {
                    aux = x;
                    x = y;
                    y = aux;
                }

                soma = (x + y) / 2;
                if (soma % 2 != 0 && soma > 5)
                {
                    Console.WriteLine(soma);
                }
                else
                {
                    Console.WriteLine(0);
                }
                n--;
            }
        }
    }
}
