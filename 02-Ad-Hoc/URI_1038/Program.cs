using System;
using System.Globalization;

namespace URI_1038
{
    class Program
    {
        /*
        Com base na tabela abaixo, escreva um programa que leia o código de um item e a quantidade deste item. 
        A seguir, calcule e mostre o valor da conta a pagar.
        Entrada: O arquivo de entrada contém dois valores inteiros correspondentes ao código e à quantidade de um item conforme tabela acima.
        Saída: O arquivo de saída deve conter a mensagem "Total: R$ " seguido pelo valor a ser pago, com 2 casas após o ponto decimal.
        Exemplo de Entrada 	Exemplo de Saída
        3 2                 Total: R$ 10.00

        4 3                 Total: R$ 6.00
         */

        static void Main( string[] args )
        {
            double hotDog = 4.00,
                   xSalada = 4.50,
                   xBacon = 5.00,
                   torrada = 2.00,
                   refri = 1.50,
                   total = 0;
            string[] s = Console.ReadLine().Split(' ');
            int cod, qtd;
            cod = int.Parse(s[0]);
            qtd = int.Parse(s[1]);
            switch (cod)
            {
                case 1:
                    total = hotDog * qtd;
                    break;
                case 2:
                    total = xSalada * qtd;
                    break;
                case 3:
                    total = xBacon * qtd;
                    break;
                case 4:
                    total = torrada * qtd;
                    break;
                case 5:
                    total = refri * qtd;
                    break;
                default:
                    Console.WriteLine("Default case");
                    break;

            }
            Console.WriteLine($"Total: R$ {total.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
