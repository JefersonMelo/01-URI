using System;

namespace URI_1115
{
    class Program
    {
        /*
        Escreva um programa para ler as coordenadas (X,Y) de uma quantidade indeterminada de pontos no sistema cartesiano. 
        Para cada ponto escrever o quadrante a que ele pertence. O algoritmo será encerrado quando pelo menos uma de duas 
        coordenadas for NULA (nesta situação sem escrever mensagem alguma).
        Entrada: A entrada contém vários casos de teste. Cada caso de teste contém 2 valores inteiros.
        Saída: Para cada caso de teste mostre em qual quadrante do sistema cartesiano se encontra a coordenada lida, conforme o exemplo.
        Exemplo de Entrada 	Exemplo de Saída
        2 2                 primeiro
        3 -2                quarto
        -8 -1               terceiro
        -7 1                segundo
        0 2
         */

        static void Main( string[] args )
        {
            int x, y;
            do
            {
                string[] s = Console.ReadLine().Split(' ');
                if (s[0] == "0" || s[1] == "0") { break; }
                x = int.Parse(s[0]);
                y = int.Parse(s[1]);

                if (x > 0 && y > 0)
                {
                    Console.WriteLine("primeiro");
                }
                else if (x < 0 && y > 0)
                {
                    Console.WriteLine("segundo");
                }
                else if (x < 0 && y < 0)
                {
                    Console.WriteLine("terceiro");
                }
                else if (x > 0 && y < 0)
                {
                    Console.WriteLine("quarto");
                }

            } while (true);
        }
    }
}
