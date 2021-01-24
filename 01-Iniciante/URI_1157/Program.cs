using System;

namespace URI_1157
{
    class Program
    {
        /*
        Ler um número inteiro N e calcular todos os seus divisores.
        Entrada: O arquivo de entrada contém um valor inteiro.
        Saída: Escreva todos os divisores positivos de N, um valor por linha.
        Exemplo de Entrada 	Exemplo de Saída
        6                   1
                            2
                            3
                            6
         */

        static void Main( string[] args )
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                if (n < 0)
                {
                    n--;
                }
                else if (n % i == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
