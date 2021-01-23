using System;

namespace URI_1044
{
    class Program
    {
        /*
        Leia 2 valores inteiros (A e B). Após, o programa deve mostrar uma mensagem "Sao Multiplos" ou "Nao sao Multiplos", 
        indicando se os valores lidos são múltiplos entre si.
        Entrada: A entrada contém valores inteiros.
        Saída: A saída deve conter uma das mensagens conforme descrito acima.
        Exemplo de Entrada 	Exemplo de Saída
        6 24                Sao Multiplos
	
        6 25                Nao sao Multiplos 
         */

        static void Main( string[] args )
        {
            string[] s = Console.ReadLine().Split(' ');
            int a, b;
            a = int.Parse(s[0]);
            b = int.Parse(s[1]);
            if (b % a == 0 || a % b == 0)
            {
                Console.WriteLine("Sao Multiplos");
            }
            else
            {
                Console.WriteLine("Nao sao Multiplos");
            }
        }
    }
}
