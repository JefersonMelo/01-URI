using System;

namespace URI_1019
{
    class Program
    {
        /*
        Leia um valor inteiro, que é o tempo de duração em segundos de um determinado evento em uma fábrica, e informe-o expresso no formato horas:minutos:segundos.
        Entrada: O arquivo de entrada contém um valor inteiro N.
        Saída: Imprima o tempo lido no arquivo de entrada (segundos), convertido para horas:minutos:segundos, conforme exemplo fornecido.
        Exemplo de Entrada 	Exemplo de Saída
        556                 0:9:16
	
        1                   0:0:1
         */

        static void Main( string[] args )
        {
            int h, m, s, n;
            n = int.Parse(Console.ReadLine());

            h = n / 3600;
            n %= 3600;
            m = n / 60;
            s = n % 60;
            Console.WriteLine(h + ":" + m + ":" + s);
        }
    }
}
