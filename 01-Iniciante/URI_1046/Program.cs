using System;

namespace URI_1046
{
    class Program
    {
        /*
        Leia a hora inicial e a hora final de um jogo. A seguir calcule a duração do jogo, sabendo que o mesmo pode começar 
        em um dia e terminar em outro, tendo uma duração mínima de 1 hora e máxima de 24 horas.
        Entrada: A entrada contém dois valores inteiros representando a hora de início e a hora de fim do jogo.
        Saída: Apresente a duração do jogo conforme exemplo abaixo.
        Exemplo de Entrada 	Exemplo de Saída
        16 2                O JOGO DUROU 10 HORA(S)
	
        0 0                 O JOGO DUROU 24 HORA(S) 
         */

        static void Main( string[] args )
        {
            string[] s = Console.ReadLine().Split(' ');
            int dia, inicio, fim;
            dia = 24;
            inicio = int.Parse(s[0]);
            fim = int.Parse(s[1]);

            if (inicio >= fim)
            {
                dia = (dia - inicio) + fim;               
            }
            else
            {
                dia = fim - inicio;                
            }
            Console.WriteLine($"O JOGO DUROU {dia} HORA(S)");
        }
    }
}
