using System;

namespace URI_1018
{
    class Program
    {
        /*
        Leia um valor inteiro. A seguir, calcule o menor número de notas possíveis (cédulas) no qual o valor pode ser decomposto. 
        As notas consideradas são de 100, 50, 20, 10, 5, 2 e 1. A seguir mostre o valor lido e a relação de notas necessárias.
        Entrada: O arquivo de entrada contém um valor inteiro N (0 < N < 1000000).
        Saída: Imprima o valor lido e, em seguida, a quantidade mínima de notas de cada tipo necessárias, conforme o exemplo fornecido. 
        Não esqueça de imprimir o fim de linha após cada linha, caso contrário seu programa apresentará a mensagem: “Presentation Error”.
        Exemplo de Entrada 	Exemplo de Saída
        576                 576
                            5 nota(s) de R$ 100,00
                            1 nota(s) de R$ 50,00
                            1 nota(s) de R$ 20,00
                            0 nota(s) de R$ 10,00
                            1 nota(s) de R$ 5,00
                            0 nota(s) de R$ 2,00
                            1 nota(s) de R$ 1,00
	
        11257               11257
                            112 nota(s) de R$ 100,00
                            1 nota(s) de R$ 50,00
                            0 nota(s) de R$ 20,00
                            0 nota(s) de R$ 10,00
                            1 nota(s) de R$ 5,00
                            1 nota(s) de R$ 2,00
                            0 nota(s) de R$ 1,00
         */

        static void Main( string[] args )
        {
            int v = int.Parse(Console.ReadLine());
            Console.WriteLine(v);

            Console.WriteLine(v / 100 + " nota(s) de R$ 100,00");//576
            v %= 100;//576 - 500 = 76
            Console.WriteLine(v / 50 + " nota(s) de R$ 50,00");//76
            v %= 50;//76 - 50 = 26
            Console.WriteLine(v / 20 + " nota(s) de R$ 20,00");//26
            v %= 20;//26 - 20 = 6
            Console.WriteLine(v / 10 + " nota(s) de R$ 10,00");//6
            v %= 10;//6 - 10 = 0
            Console.WriteLine(v / 5 + " nota(s) de R$ 5,00");//6
            v %= 5;//6 - 5 = 1
            Console.WriteLine(v / 2 + " nota(s) de R$ 2,00");//1
            v %= 2;//1 - 2 = 0
            Console.WriteLine(v + " nota(s) de R$ 1,00");//1
        }
    }
}
