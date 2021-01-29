using System;
using System.Globalization;
namespace URI_1094
{
    class Program
    {
        /*
        Maria acabou de iniciar seu curso de graduação na faculdade de medicina e precisa de sua ajuda para organizar 
        os experimentos de um laboratório o qual ela é responsável. Ela quer saber no final do ano, quantas cobaias foram 
        utilizadas no laboratório e o percentual de cada tipo de cobaia utilizada. Este laboratório em especial utiliza três 
        tipos de cobaias: sapos, ratos e coelhos. Para obter estas informações, ela sabe exatamente o número de experimentos 
        que foram realizados, o tipo de cobaia utilizada e a quantidade de cobaias utilizadas em cada experimento.
        Entrada: A primeira linha de entrada contém um valor inteiro N que indica os vários casos de teste que vem a seguir. 
        Cada caso de teste contém um inteiro Quantia (1 ≤ Quantia ≤ 15) que representa a quantidade de cobaias utilizadas e um 
        caractere Tipo ('C', 'R' ou 'S'), indicando o tipo de cobaia (R:Rato S:Sapo C:Coelho).
        Saída: Apresente o total de cobaias utilizadas, o total de cada tipo de cobaia utilizada e o percentual de cada uma em 
        relação ao total de cobaias utilizadas, sendo que o percentual deve ser apresentado com dois dígitos após o ponto.
        Exemplo de Entrada 	Exemplo de Saída
        10                  Total: 92 cobaias
        10 C                Total de coelhos: 29
        6 R                 Total de ratos: 40
        15 S                Total de sapos: 23
        5 C                 Percentual de coelhos: 31.52 %
        14 R                Percentual de ratos: 43.48 %
        9 C                 Percentual de sapos: 25.00 % 
        6 R
        8 S
        5 C
        14 R
         */

        static void Main( string[] args )
        {
            int n = int.Parse(Console.ReadLine());
            int c = 0, s = 0, r = 0, qtd;
            double total, pc, ps, pr;
            char cob;
            while (n > 0)
            {
                string[] vet = Console.ReadLine().Split(' ');
                qtd = int.Parse(vet[0]);
                cob = char.Parse(vet[1]);
                if (cob == 'C')//Coelho
                {
                    c += qtd;
                }
                else if (cob == 'R')//Rato
                {
                    r += qtd;
                }
                else if (cob == 'S')//Sapo
                {
                    s += qtd;
                }
                n--;
            }
            total = c + r + s;
            pc = 100.0 * (c / total);
            pr = 100.0 * (r / total);
            ps = 100.0 * (s / total);
            Console.WriteLine($"Total: {total} cobaias\n" +
                               $"Total de coelhos: {c}\n" +
                               $"Total de ratos: {r}\n" +
                               $"Total de sapos: {s}\n" +
                               $"Percentual de coelhos: {pc.ToString("F2", CultureInfo.InvariantCulture)} %\n" +
                               $"Percentual de ratos: {pr.ToString("F2", CultureInfo.InvariantCulture)} %\n" +
                               $"Percentual de sapos: {ps.ToString("F2", CultureInfo.InvariantCulture)} %");

        }
    }
}
