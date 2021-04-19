using System;

namespace URI_1047
{
    class Program
    {
        /*
        Leia a hora inicial, minuto inicial, hora final e minuto final de um jogo. A seguir calcule a duração do jogo.
        Obs: O jogo tem duração mínima de um (1) minuto e duração máxima de 24 horas.
        Entrada: Quatro números inteiros representando a hora de início e fim do jogo.
        Saída: Mostre a seguinte mensagem: “O JOGO DUROU XXX HORA(S) E YYY MINUTO(S)” .
        Exemplo de Entrada 	Exemplo de Saída
        7 8 9 10            O JOGO DUROU 2 HORA(S) E 2 MINUTO(S)
	    
        7 7 7 7             O JOGO DUROU 24 HORA(S) E 0 MINUTO(S)
         */
        // Erro no uri. Ide ok
        static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split(' ');
            int horaInicio, minutoInicio, horaFim, minutoFim;/*, horasTotais, minutosTotais*/
            //horasTotais = 24;
            horaInicio = int.Parse(s[0]);
            minutoInicio = int.Parse(s[1]);
            horaFim = int.Parse(s[2]);
            minutoFim = int.Parse(s[3]);

            TimeSpan ts1 = new TimeSpan(horaInicio, minutoInicio, 0);
            TimeSpan ts2 = new TimeSpan(horaFim, minutoFim, 0);
            if ( ts1 == ts2 )
            {
                Console.WriteLine("O JOGO DUROU 24 HORA(S) E 0 MINUTO(S)");
            }
            else if ( ts1 > ts2 )
            {
                string[] ss = ( ts1 -= ts2 ).ToString().Split(':');
                int h = int.Parse(ss[0]);
                int m = int.Parse(ss[1]);
                //Console.WriteLine(ss);
                Console.WriteLine($"O JOGO DUROU {h} HORA(S) E {m} MINUTO(S)");
            }
            else
            {
                string[] ss = ( ts2 -= ts1 ).ToString().Split(':');
                int h = int.Parse(ss[0]);
                int m = int.Parse(ss[1]);
                //Console.WriteLine(ts2);
                Console.WriteLine($"O JOGO DUROU {h} HORA(S) E {m} MINUTO(S)");
            }
        }
    }
}
