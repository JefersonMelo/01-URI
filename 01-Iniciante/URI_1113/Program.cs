using System;

namespace URI_1113
{
    class Program
    {
        /*
        Leia uma quantidade indeterminada de duplas de valores inteiros X e Y. Escreva para cada 
        X e Y uma mensagem que indique se estes valores foram digitados em ordem crescente ou decrescente.
        Entrada: A entrada contém vários casos de teste. Cada caso contém dois valores inteiros X e Y. 
        A leitura deve ser encerrada ao ser fornecido valores iguais para X e Y.
        Saída: Para cada caso de teste imprima “Crescente”, caso os valores tenham sido digitados na ordem 
        crescente, caso contrário imprima a mensagem “Decrescente”.
        Exemplo de Entrada 	Exemplo de Saída
        5 4                 Decrescente
        7 2                 Decrescente
        3 8                 Crescente
        2 2
        */

        static void Main( string[] args )
        {
            do
            {
                int x, y;
                string[] s = Console.ReadLine().Split();
                x = int.Parse(s[0]);
                y = int.Parse(s[1]);
                if (x == y) { break; }
                if (x > y)
                {
                    Console.WriteLine("Decrescente");
                }
                else
                {
                    Console.WriteLine("Crescente");
                }
            } while (true);
        }
    }
}
