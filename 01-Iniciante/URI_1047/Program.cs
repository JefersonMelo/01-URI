using System;
using System.Globalization;

namespace URI_1047
{
    class Program
    {
        public static bool MathChallenge(string num)
        {
            int x = int.Parse(num);
            int cont = 0;
            if ( x == 2 )
            {
                Console.WriteLine("verdadeiro");
            }
            for ( int i = 2; i < x; i++ )
            {
                if ( x % i == 0 ) cont++;
            }
            if ( cont == 0 )
            {
                return true;
            }
            else
            {
                return false;
            }
            // code goes here  
            

        }


        static void Main(string[] args)
        {
            Console.WriteLine(MathChallenge(Console.ReadLine()));

            //int x = int.Parse(Console.ReadLine());
            //int cont = 0;
            //if ( x == 2 )
            //{
            //    Console.WriteLine("verdadeiro");
            //}
            //for ( int i = 2; i < x; i++ )
            //{
            //    if ( x % i == 0 ) cont++;
            //}
            //if ( cont == 0 )
            //{
            //    Console.WriteLine("verdadeiro");
            //}
            //else
            //{
            //    Console.WriteLine("falsa");
            //}

            //int N = int.Parse(Console.ReadLine());
            //int X, cont;
            //for ( int i = 0; i < N; i++ )
            //{
            //    cont = 0;
            //    X = int.Parse(Console.ReadLine());
            //    for ( int j = 2; j < X; j++ )
            //    {
            //        if ( X % j == 0 ) cont++;
            //    }
            //    if ( cont == 0 ) Console.WriteLine(X + " eh primo");

            //    else Console.WriteLine(X + " nao eh primo");
            //}


            //string[] s = Console.ReadLine().Split(' ');
            //int horaInicio, minutoInicio, horaFim, minutoFim, tempoTotalInicio, tempoTotalFim;
            ////horasTotais = 24;
            //int h = 0, m = 0;
            //horaInicio = int.Parse(s[0]);
            //minutoInicio = int.Parse(s[1]);
            //horaFim = int.Parse(s[2]);
            //minutoFim = int.Parse(s[3]);

            //horaInicio *= 60;
            //horaFim *= 60;

            //tempoTotalInicio = horaInicio + minutoInicio;
            //tempoTotalFim = horaFim + minutoFim;

            //var ts1 = new TimeSpan(horaInicio, minutoInicio, 0);
            //var ts2 = new TimeSpan(horaFim, minutoFim, 0);
            ////TimeSpan travelTime = ts1 - ts2;
            ////Console.WriteLine(ts1 - ts2);

            //if ( tempoTotalInicio == tempoTotalFim )
            //{
            //    Console.WriteLine("O JOGO DUROU 24 HORA(S) E 0 MINUTO(S)");
            //}
            //else if ( tempoTotalInicio > tempoTotalFim )
            //{
            //    if ( ( tempoTotalInicio - tempoTotalFim ) < 60 )
            //    {

            //    }
            //    //string[] ss = ( ts1 - ts2 ).ToString().Split(':');
            //    h = ( tempoTotalInicio - tempoTotalFim );//int.Parse(ss[0]);
            //    m = h % 60;//int.Parse(ss[1]);
            //    //Console.WriteLine(ss);
            //    //Console.WriteLine($"O JOGO DUROU {h} HORA(S) E {m} MINUTO(S)");
            //}
            //else if ( ts1 < ts2 )
            //{
            //    string[] ss = ( ts2 - ts1 ).ToString().Split(':');
            //    h = int.Parse(ss[0]);
            //    m = int.Parse(ss[1]);
            //    //Console.WriteLine(ts2);
            //    //Console.WriteLine($"O JOGO DUROU {h} HORA(S) E {m} MINUTO(S)");
            //}
            //else
            //{
            //    string[] ss = ( ts2 += ts1 ).ToString().Split(':');
            //    h = int.Parse(ss[0]);
            //    m = int.Parse(ss[1]);
            //    //Console.WriteLine(ts2);
            //    //Console.WriteLine($"O JOGO DUROU {h} HORA(S) E {m} MINUTO(S)");
            //}
            //Console.WriteLine($"O JOGO DUROU {h} HORA(S) E {m} MINUTO(S)");
        }


    }
}
