using System;

namespace URI_1071
{
    class Program
    {
        /*
        Leia 2 valores inteiros X e Y. A seguir, calcule e mostre a soma dos números impares entre eles.
        Entrada: O arquivo de entrada contém dois valores inteiros.
        Saída: O programa deve imprimir um valor inteiro. Este valor é a soma dos valores ímpares que estão entre 
        os valores fornecidos na entrada que deverá caber em um inteiro.
        Exemplo de Entrada 	Exemplo de Saída
        6                   5
        -5
	
        15                  13 
        12
        */

        static void Main( string[] args )
        {
            int x, y, aux, soma = 0;
            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());

            if (x < y)
            {
                aux = x;
                x = y;
                y = aux;
            }
            if (y < 0)
            {
                y++;
            }

            while (x > y)
            {
                if (y % 2 != 0)
                {
                    soma += y;
                }
                y++;
            }
            Console.WriteLine(soma);
        }
    }
}
