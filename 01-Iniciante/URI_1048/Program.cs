using System;
using System.Globalization;

namespace URI_1048
{
    class Program
    {
        /*
        A empresa ABC resolveu conceder um aumento de salários a seus funcionários de acordo com a tabela abaixo:
                    Salário 	        Percentual de Reajuste
                    0 - 400.00          15%
                    400.01 - 800.00     12%
                    800.01 - 1200.00    10%
                    1200.01 - 2000.00   7%
                    Acima de 2000.00    4%
	    Leia o salário do funcionário e calcule e mostre o novo salário, bem como o valor de reajuste ganho e o índice reajustado, em percentual.
        Entrada: A entrada contém apenas um valor de ponto flutuante, com duas casas decimais.
        Saída: Imprima 3 linhas na saída: o novo salário, o valor ganho de reajuste e o percentual de reajuste ganho, conforme exemplo abaixo.
        Exemplo de Entrada 	Exemplo de Saída
        400.00              Novo salario: 460.00
                            Reajuste ganho: 60.00
                            Em percentual: 15 %
	
        800.01              Novo salario: 880.01
                            Reajuste ganho: 80.00
                            Em percentual: 10 %
         */

        static void Main( string[] args )
        {
            double reajuste, p;
            p = 1.0 / 100.0;
            reajuste = 0;
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (salario <= 400.00)
            {
                reajuste = salario * (15.0 * p);
                salario += salario * (15.0 * p);
                p *= 15.0 * 100.0;
            }
            else if (salario > 400.00 && salario <= 800.00)
            {
                reajuste = salario * (12.0 * p);
                salario += salario * (12.0 * p);
                p *= 12.0 * 100.0;
            }
            else if (salario > 800.00 && salario <= 1200.00)
            {
                reajuste = salario * (10.0 * p);
                salario += salario * (10.0 * p);
                p *= 10.0 * 100.0;
            }
            else if (salario > 1200.00 && salario <= 2000.00)
            {
                reajuste = salario * (7.0 * p);
                salario += salario * (7.0 * p);
                p *= 7.0 * 100.0;
            }
            else if (salario > 2000.00)
            {
                reajuste = salario * (4.0 * p);
                salario += salario * (4.0 * p);
                p *= 4.0 * 100.0;
            }
            Console.WriteLine($"Novo salario: {salario.ToString("F2", CultureInfo.InvariantCulture)}\n" +
                                $"Reajuste ganho: {reajuste.ToString("F2", CultureInfo.InvariantCulture)}\n" +
                                $"Em percentual: {p} %");
        }
    }
}
