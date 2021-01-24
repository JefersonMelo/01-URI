using System;

namespace URI_1070
{
    class Program
    {
        /*
        Leia um valor inteiro X. Em seguida apresente os 6 valores ímpares consecutivos a partir de X, um valor por linha, inclusive o X ser for o caso.
        Entrada: A entrada será um valor inteiro positivo.
        Saída: A saída será uma sequência de seis números ímpares.
        Exemplo de Entrada 	Exemplo de Saída
        8                   9
                            11
                            13
                            15
                            17
                            19 
	    */

        static void Main( string[] args )
        {
            int n, cont = 0;
            n = int.Parse(Console.ReadLine());

            if (n % 2 == 0)
            {
                n++;
            }
            while (cont < 6)
            {
                Console.WriteLine(n);
                cont++;
                n += 2;
            }
        }
    }
}
