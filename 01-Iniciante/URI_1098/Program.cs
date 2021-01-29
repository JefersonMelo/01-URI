using System;
using System.Globalization;

namespace URI_1098
{
    class Program
    {
        /*
        Você deve fazer um programa que apresente a sequencia conforme o exemplo abaixo.
        Entrada: Não há nenhuma entrada neste problema.
        Saída: Imprima a sequencia conforme exemplo abaixo.
        Exemplo de Entrada 	Exemplo de Saída
                            I=0 J=1
                            I=0 J=2
                            I=0 J=3
                            I=0.2 J=1.2
                            I=0.2 J=2.2
                            I=0.2 J=3.2
                            .....
                            I=2 J=?
                            I=2 J=?
                            I=2 J=? 
         */

        static void Main( string[] args )
        {
            //nt j = 1;
            for (double i = 0.0; i <= 2.0; i += .2)
            {

                for (double j = 1; j <= 3; j++)
                {
                    if (i % 2.0 == 0.0)
                    {
                        Console.WriteLine($"I = {i} J = {j + i}");
                    }
                    else
                    {
                        Console.WriteLine($"I = {i.ToString("F1", CultureInfo.InvariantCulture)} J = {(j + i).ToString("F1", CultureInfo.InvariantCulture)}");
                    }
                }
            }
        }
    }
}
