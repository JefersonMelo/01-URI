using System;

namespace URI_1047
{
    class Program
    {
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
                //Console.WriteLine($"O JOGO DUROU {horasTotais} HORA(S) E {minutosTotais} MINUTO(S)");
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
                //Console.WriteLine($"O JOGO DUROU {horasTotais} HORA(S) E {minutosTotais} MINUTO(S)");
            }
            Console.WriteLine($"O JOGO DUROU {horasTotais} HORA(S) E {minutosTotais} MINUTO(S)");
        }
    }
}
