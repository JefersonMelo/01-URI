using System;
using System.Globalization;

namespace URI_1048
{
    class Program
    {
        static void Main(string[] args)
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
