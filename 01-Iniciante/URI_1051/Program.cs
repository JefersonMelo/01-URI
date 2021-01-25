using System;
using System.Globalization;

namespace URI_1051
{
    class Program
    {
        /*
        Em um país imaginário denominado Lisarb, todos os habitantes ficam felizes em pagar seus impostos, pois sabem que nele 
        não existem políticos corruptos e os recursos arrecadados são utilizados em benefício da população, sem qualquer desvio. 
        A moeda deste país é o Rombus, cujo símbolo é o R$. Leia um valor com duas casas decimais, equivalente ao salário de uma 
        pessoa de Lisarb. Em seguida, calcule e mostre o valor que esta pessoa deve pagar de Imposto de Renda, segundo a tabela abaixo.
        Lembre que, se o salário for R$ 3002.00, a taxa que incide é de 8% apenas sobre R$ 1000.00, pois a faixa de salário que fica 
        de R$ 0.00 até R$ 2000.00 é isenta de Imposto de Renda. No exemplo fornecido (abaixo), a taxa é de 8% sobre R$ 1000.00 + 
        18% sobre R$ 2.00, o que resulta em R$ 80.36 no total. O valor deve ser impresso com duas casas decimais.
        Entrada: A entrada contém apenas um valor de ponto flutuante, com duas casas decimais.
        Saída: Imprima o texto "R$" seguido de um espaço e do valor total devido de Imposto de Renda, com duas casas após o ponto. 
        Se o valor de entrada for menor ou igual a 2000, deverá ser impressa a mensagem "Isento".
        Exemplos de Entrada 	Exemplos de Saída
        3002.00                 R$ 80.36

        1701.12                 Isento 
         */

        static void Main( string[] args )
        {
            double v, imp = 0.0, r08, r18, r28, isento = 2000.0;
            v = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            if (v < isento)
            {
                Console.WriteLine("Isento");
            }
            else
            {
                if (v <= 3000.0)//8%
                {
                    v -= isento;
                    imp = v * 0.08;

                }
                else if (v > 3000.0 && v <= 4500.0)//18%
                {
                    v -= isento;
                    r18 = v - 1000.0;
                    r08 = v - r18;
                    imp = r08 * 0.08 + (r18 * 0.18);
                }
                else if (v > 4500.0)//28%
                {
                    r08 = 1000.0;
                    r18 = 1500.0;
                    v -= r08 + r18;
                    r28 = v - isento;
                    imp = (r08 * 0.08) + (r18 * 0.18) + (r28 * 0.28);

                }
                Console.WriteLine($"R$ {imp.ToString("F2", CultureInfo.InvariantCulture)}");
            }
        }
    }
}
