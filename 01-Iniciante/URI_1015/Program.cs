using System;
using System.Globalization;

namespace URI_1015
{
    class Program
    {
        /*
        Leia os quatro valores correspondentes aos eixos x e y de dois pontos quaisquer no plano, p1(x1,y1) e p2(x2,y2) e 
        calcule a distância entre eles, mostrando 4 casas decimais após a vírgula, segundo a fórmula:
        Entrada: O arquivo de entrada contém duas linhas de dados. A primeira linha contém dois valores de ponto 
        flutuante: x1 y1 e a segunda linha contém dois valores de ponto flutuante x2 y2.
        Saída: Calcule e imprima o valor da distância segundo a fórmula fornecida, com 4 casas após o ponto decimal.
        Exemplo de Entrada 	Exemplo de Saída
        1.0 7.0             4.4721
        5.0 9.0
	
        -2.5 0.4            16.1484
        12.1 7.3
         */

        static void Main( string[] args )
        {

            double x1, y1, x2, y2;
            string[] s = Console.ReadLine().Split(' ');
            string[] ss = Console.ReadLine().Split(' ');
            x1 = double.Parse(s[0], CultureInfo.InvariantCulture);
            y1 = double.Parse(s[1], CultureInfo.InvariantCulture);
            x2 = double.Parse(ss[0], CultureInfo.InvariantCulture);
            y2 = double.Parse(ss[1], CultureInfo.InvariantCulture);

            Console.WriteLine(Math.Sqrt(Math.Pow(x2 - x1, 2.0) + Math.Pow(y2 - y1, 2.0)).ToString("F4"));

        }
    }
}
