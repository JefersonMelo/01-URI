using System;

namespace URI_1118
{
    class Program
    {
        /*
        Escreva um programa para ler as notas da primeira e a segunda avaliação de um aluno. Calcule e imprima a média semestral. 
        O programa só deverá aceitar notas válidas (uma nota válida deve pertencer ao intervalo [0,10]). Cada nota deve ser validada 
        separadamente. No final deve ser impressa a mensagem “novo calculo (1-sim 2-nao)”, solicitando ao usuário que informe um 
        código (1 ou 2) indicando se ele deseja ou não executar o algoritmo novamente, (aceitar apenas os código 1 ou 2). 
        Se for informado o código 1 deve ser repetida a execução de todo o programa para permitir um novo cálculo, caso contrário o 
        programa deve ser encerrado.
        Entrada: O arquivo de entrada contém vários valores reais, positivos ou negativos. Quando forem lidas duas notas válidas, 
        deve ser lido um valor inteiro X . O programa deve parar quando o valor lido para este X for igual a 2.
        Saída: Se uma nota inválida for lida, deve ser impressa a mensagem “nota invalida”. Quando duas notas válidas forem lidas, 
        deve ser impressa a mensagem “media = ” seguido do valor do cálculo. Antes da leitura de X deve ser impressa a mensagem 
        "novo calculo (1-sim 2-nao)" e esta mensagem deve ser apresentada novamente se o valor da entrada padrão para X for menor 
        do que 1 ou maior do que 2, conforme o exemplo abaixo. A média deve ser impressa com dois dígitos após o ponto decimal.
        Exemplo de Entrada 	Exemplo de Saída
        -3.5                nota invalida
        3.5                 nota invalida
        11.0                media = 6.75
        10.0                novo calculo (1-sim 2-nao)
        4                   novo calculo (1-sim 2-nao)
        1
        8.0                 
        9.0                 media = 8.50
        2                   novo calculo (1-sim 2-nao)
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
                    Console.WriteLine("novo calculo (1-sim 2-nao)");
                    int nv = int.Parse(Console.ReadLine());
                    if (nv == 2)
                    {
                        break;
                    }
                    else
                    {
                        chec = true;
                    }
                }

            } while (chec != false);
        }
    }
}
