using System;
using System.Globalization;
namespace URI_1021
{
    class Program
    {
        /*
        Leia um valor de ponto flutuante com duas casas decimais. Este valor representa um valor monetário. A seguir, 
        calcule o menor número de notas e moedas possíveis no qual o valor pode ser decomposto. As notas consideradas 
        são de 100, 50, 20, 10, 5, 2. As moedas possíveis são de 1, 0.50, 0.25, 0.10, 0.05 e 0.01. A seguir mostre a relação de notas necessárias.
        Entrada: O arquivo de entrada contém um valor de ponto flutuante N (0 ≤ N ≤ 1000000.00).
        Saída: Imprima a quantidade mínima de notas e moedas necessárias para trocar o valor inicial, conforme exemplo fornecido. 
        Obs: Utilize ponto (.) para separar a parte decimal.
        Exemplo de Entrada 	Exemplo de Saída
        576.73              NOTAS:
                            5 nota(s) de R$ 100.00
                            1 nota(s) de R$ 50.00
                            1 nota(s) de R$ 20.00
                            0 nota(s) de R$ 10.00
                            1 nota(s) de R$ 5.00
                            0 nota(s) de R$ 2.00
                            MOEDAS:
                            1 moeda(s) de R$ 1.00
                            1 moeda(s) de R$ 0.50
                            0 moeda(s) de R$ 0.25
                            2 moeda(s) de R$ 0.10
                            0 moeda(s) de R$ 0.05
                            3 moeda(s) de R$ 0.01
	
        4.00                NOTAS:
                            0 nota(s) de R$ 100.00
                            0 nota(s) de R$ 50.00
                            0 nota(s) de R$ 20.00
                            0 nota(s) de R$ 10.00
                            0 nota(s) de R$ 5.00
                            2 nota(s) de R$ 2.00
                            MOEDAS:
                            0 moeda(s) de R$ 1.00
                            0 moeda(s) de R$ 0.50
                            0 moeda(s) de R$ 0.25
                            0 moeda(s) de R$ 0.10
                            0 moeda(s) de R$ 0.05
                            0 moeda(s) de R$ 0.01
         */

        static void Main( string[] args )
        {
            double v = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine(v.ToString(CultureInfo.InvariantCulture));

            Console.WriteLine($"{Math.Truncate(v / 100)} nota(s) de R$ 100.00");//576
            v %= 100;//576 - 500 = 76
            Console.WriteLine($"{Math.Truncate(v / 50)} nota(s) de R$ 50.00");//76  
            v %= 50;//76 - 50 = 26
            Console.WriteLine($"{Math.Truncate(v / 20)} nota(s) de R$ 20.00");//26
            v %= 20;//26 - 20 = 6
            Console.WriteLine($"{Math.Truncate(v / 10)} nota(s) de R$ 10.00");//6
            v %= 10;//6 - 10 = 0
            Console.WriteLine($"{Math.Truncate(v / 5)} nota(s) de R$ 5.00");//6
            v %= 5;//6 - 5 = 1
            Console.WriteLine($"{Math.Truncate(v / 2)} nota(s) de R$ 2.00");//1
            //moedas
            v %= 2;
            Console.WriteLine($"{Math.Truncate(v)} moeda(s) de R$ 1.00");
            v %= 1.0;
            Console.WriteLine($"{Math.Truncate(v / 0.50)} moeda(s) de R$ 0.50");
            v %= 0.50;
            Console.WriteLine($"{Math.Truncate(v / 0.25)} moeda(s) de R$ 0.25");
            v %= 0.25;
            Console.WriteLine($"{Math.Truncate(v / 0.10)} moeda(s) de R$ 0.10");
            v %= 0.10;
            Console.WriteLine($"{Math.Truncate(v / 0.5)} moeda(s) de R$ 0.05");
            v %= 0.5;
            Console.WriteLine($"{Math.Truncate(v / 0.1)} moeda(s) de R$ 0.01");

            //Não foi aceito. Plataforma aparentemente não aceita Math.Truncate
        }
    }
}
