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
        // erro de compilação. Ide ok.
        static void Main( string[] args )
        {
            string[] s = Console.ReadLine().Split(' ');
            int horaInicio, minutoInicio, horaFim, minutoFim, horasTotais, minutosTotais;
            horasTotais = 24;
            horaInicio = int.Parse(s[0]);
            minutoInicio = int.Parse(s[1]);
            horaFim = int.Parse(s[2]);
            minutoFim = int.Parse(s[3]);

            if (horaInicio >= horaFim)
            {
                horasTotais = horasTotais - horaInicio + horaFim;
                if (minutoInicio >= minutoFim)
                {
                    minutosTotais = minutoInicio - minutoFim;
                }
                else
                {
                    minutosTotais = minutoFim - minutoInicio;
                }
            }
            else if (horaInicio < horaFim && minutoInicio > minutoFim)
            {
                horasTotais = horaInicio - horaFim;
                if (horasTotais < 0 && minutoInicio > minutoFim)
                {
                    horasTotais = 0;
                    minutosTotais = minutoInicio - minutoFim;
                    minutosTotais = 60 - minutosTotais;
                }
                else
                {
                    minutosTotais = minutoFim - minutoInicio;
                }
            }
            else
            {
                horasTotais = horaFim - horaInicio;
                minutosTotais = minutoFim - minutoInicio;
            }
            Console.WriteLine($"O JOGO DUROU {horasTotais} HORA(S) E {minutosTotais} MINUTO(S)");
        }
    }
}
