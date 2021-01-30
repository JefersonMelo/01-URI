using System;

namespace URI_1101
{
    class Program
    {
        /*
        Leia um conjunto não determinado de pares de valores M e N (parar quando algum dos valores for menor ou igual a zero). 
        Para cada par lido, mostre a sequência do menor até o maior e a soma dos inteiros consecutivos entre eles (incluindo o N e M).
        Entrada: O arquivo de entrada contém um número não determinado de valores M e N. A última linha de entrada vai conter um número nulo ou negativo.
        Saída: Para cada dupla de valores, imprima a sequência do menor até o maior e a soma deles, conforme exemplo abaixo.
        Exemplo de Entrada 	Exemplo de Saída
        5 2                 2 3 4 5 Sum=14
        6 3                 3 4 5 6 Sum=18
        5 0
        */
        static void Main( string[] args )
        {
            int n, m, aux, soma = 0;
            do
            {
                string[] s = Console.ReadLine().Split(' ');
                n = int.Parse(s[0]);
                m = int.Parse(s[1]);

                if (n <= 0 || m <= 0)
                {
                    break;
                }
                else
                {
                    if (n > m)//garantir m sempre o maior
                    {
                        aux = n;
                        n = m;
                        m = aux;
                    }
                    for (int i = n; i <= m; i++)
                    {
                        soma += i;
                        Console.Write($"{i} ");
                    }
                    Console.Write($"Sum={soma}\n");
                    soma = 0;
                }

            } while (true);
        }
    }
}
