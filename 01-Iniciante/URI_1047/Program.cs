using System;

namespace URI_1047
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split(' ');
            int horaInicio, minutoInicio, horaFim, minutoFim, tempoTotalInicio, tempoTotalFim;
            //horasTotais = 24;
            int h = 0, m = 0;
            horaInicio = int.Parse(s[0]);
            minutoInicio = int.Parse(s[1]);
            horaFim = int.Parse(s[2]);
            minutoFim = int.Parse(s[3]);

            horaInicio *= 60;
            horaFim *= 60;

            tempoTotalInicio = horaInicio + minutoInicio;
            tempoTotalFim = horaFim + minutoFim;

            //var ts1 = new TimeSpan(horaInicio, minutoInicio, 0);
            //var ts2 = new TimeSpan(horaFim, minutoFim, 0);
            //TimeSpan travelTime = ts1 - ts2;
            //Console.WriteLine(ts1 - ts2);

            if ( tempoTotalInicio == tempoTotalFim )
            {
                Console.WriteLine("O JOGO DUROU 24 HORA(S) E 0 MINUTO(S)");
            }
            if ( tempoTotalInicio > tempoTotalFim )
            {
                //if ( ( tempoTotalInicio - tempoTotalFim ) < 60 )
                //{

                //}
                //string[] ss = ( ts1 - ts2 ).ToString().Split(':');
                h = ( tempoTotalInicio - tempoTotalFim ) / 60;//int.Parse(ss[0]);
                m = 60 - ( tempoTotalInicio - tempoTotalFim );//int.Parse(ss[1]);
                //Console.WriteLine(ss);
                //Console.WriteLine($"O JOGO DUROU {h} HORA(S) E {m} MINUTO(S)");
            }
            else //if ( tempoTotalInicio < tempoTotalFim )
            {
                //string[] ss = ( ts2 - ts1 ).ToString().Split(':');
                h = ( tempoTotalFim - tempoTotalInicio ) / 60;//int.Parse(ss[0]);
                m = ( tempoTotalFim - tempoTotalInicio )- 60;//int.Parse(ss[1]);
                //Console.WriteLine(ts2);
                //Console.WriteLine($"O JOGO DUROU {h} HORA(S) E {m} MINUTO(S)");
            }
            Console.WriteLine($"O JOGO DUROU {h} HORA(S) E {m} MINUTO(S)");
        }
    }
}
