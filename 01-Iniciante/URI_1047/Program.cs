using System;

namespace URI_1047
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split();
            int horaInicio, minutoInicio, horaFim, minutoFim;
            horaInicio = int.Parse(s[0]);
            minutoInicio = int.Parse(s[1]);
            horaFim = int.Parse(s[2]);
            minutoFim = int.Parse(s[3]);

            int duracao = ( horaFim * 60 + minutoFim ) - ( horaInicio * 60 + minutoInicio );

            if ( duracao <= 0 )
            {
                duracao = duracao + ( 60 * 24 );
                Console.WriteLine($"O JOGO DUROU {duracao / 60} HORA(S) E {duracao % 60} MINUTO(S)");
            }
            else
            {
                Console.WriteLine($"O JOGO DUROU {duracao / 60} HORA(S) E {duracao % 60} MINUTO(S)");
            }
        }
    }
}
