using System;

namespace URI_1117
{
    class Program
    {
        /*
        Faça um programa que leia as notas referentes às duas avaliações de um aluno. Calcule e imprima a média semestral. 
        Faça com que o algoritmo só aceite notas válidas (uma nota válida deve pertencer ao intervalo [0,10]). 
        Cada nota deve ser validada separadamente.
        Entrada: A entrada contém vários valores reais, positivos ou negativos. O programa deve ser encerrado quando 
        forem lidas duas notas válidas.
        Saída: Se uma nota inválida  for lida, deve ser impressa a mensagem "nota invalida".
        Quando duas notas válidas forem lidas, deve ser impressa a mensagem "media = " seguido do valor do cálculo. 
        O valor deve ser apresentado com duas casas após o ponto decimal.
        Exemplo de Entrada 	Exemplo de Saída
        -3.5                nota invalida
        3.5                 nota invalida
        11.0                media = 6.75
        10.0
         */

        static void Main( string[] args )
        {
            double a, b, r;
            double[] v = new double[2];
            bool chec = true;
            do
            {
                while (chec != false)
                {
                    a = double.Parse(Console.ReadLine());
                    if (a < 0 || a > 10)
                    {
                        Console.WriteLine("nota invalida");
                    }
                    else
                    {
                        v[0] = a;
                        chec = false;
                    }
                }
                chec = true;
                while (chec != false)
                {
                    b = double.Parse(Console.ReadLine());
                    if (b < 0 || b > 10)
                    {
                        Console.WriteLine("nota invalida");
                    }
                    else
                    {
                        v[1] = b;
                        chec = false;
                    }
                }

                if (v[0] > 0 && v[1] > 0)
                {
                    r = (v[0] + v[1]) / 2;
                    Console.WriteLine($"media = {r:n2}");
                    break;
                }

            } while (true);
        }
    }
}
