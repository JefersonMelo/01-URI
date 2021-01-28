using System;

namespace URI_1075
{
    class Program
    {
        /*
        Leia um valor inteiro N. Apresente todos os números entre 1 e 10000 que divididos por N dão resto igual a 2.
        Entrada: A entrada contém um valor inteiro N (N < 10000).
        Saída: Imprima todos valores que quando divididos por N dão resto = 2, um por linha.
        Exemplo de Entrada 	Exemplo de Saída
        13                  2
                            15
                            28
                            41 
	



         */
        static void Main( string[] args )
        {
            int x = int.Parse(Console.ReadLine());
            for (int i = 1; i < 10000; i++)
            {
                if (i % x == 2)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
