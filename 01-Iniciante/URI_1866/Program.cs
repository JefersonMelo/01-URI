using System;

namespace URI_1866
{
    class Program
    {
        /*
        Dois amigos pedem ao atendente de uma lanchonete propor um desafio, de modo que quem acertasse mais, não precisaria pagar a conta. 
        Então foi proposto o seguinte: Dado o seguinte somatório abaixo, informar o resultado, com uma quantidade de termos no mesmo:
        S = 1 - 1 + 1 - 1 + 1 - 1 + 1 - 1 ...
        Escreva um programa que, dada uma quantidade de termos, informar o resultado do somatório acima.
        Entrada: Um número inteiro C será informado, que será a quantidade de casos de teste. Cada caso de teste inicia com um número 
        inteiro N (1 ≤ N ≤ 1000), indicando a quantidade de termos da soma.
        Saída: Para cada caso de teste imprima um número S, que é o resultado da soma dos N termos da expressão.
        Exemplo de Entrada 	Exemplo de Saída
        3                   1
        11                  1
        7                   0 
        18
         */
        static void Main( string[] args )
        {
            int c, s;
            c = int.Parse(Console.ReadLine());
            for (int i = 0; i < c; i++)
            {
                s = int.Parse(Console.ReadLine());
                if (s % 2 == 0)
                {
                    Console.WriteLine(0);
                }
                else if (s % 2 != 0)
                {
                    Console.WriteLine(1);
                }

            }
        }
    }
}
