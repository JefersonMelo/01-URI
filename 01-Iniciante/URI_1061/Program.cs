using System;

namespace URI_1061
{
    class Program
    {
        /*
        Pedrinho está organizando um evento em sua Universidade. O evento deverá ser no mês de Abril, iniciando e terminando dentro do mês. 
        O problema é que Pedrinho quer calcular o tempo que o evento vai durar, uma vez que ele sabe quando inicia e quando termina o evento.
        Sabendo que o evento pode durar de poucos segundos a vários dias, você deverá ajudar Pedrinho a calcular a duração deste evento.
        Entrada: Como entrada, na primeira linha vai haver a descrição “Dia”, seguido de um espaço e o dia do mês no qual o evento vai começar. 
        Na linha seguinte, será informado o momento no qual o evento vai iniciar, no formato hh : mm : ss. Na terceira e quarta linha de entrada 
        haverá outra informação no mesmo formato das duas primeiras linhas, indicando o término do evento.
        Saída: Na saída, deve ser apresentada a duração do evento, no seguinte formato:
            W dia(s)
            X hora(s)
            Y minuto(s)
            Z segundo(s)
        Obs: Considere que o evento do caso de teste para o problema tem duração mínima de 1 minuto.
        Exemplo de Entrada 	Exemplo de Saída
        Dia 5               3 dia(s)
        08 : 12 : 23        22 hora(s)
        Dia 9               1 minuto(s)
        06 : 13 : 23        0 segundo(s)
         */

        // erro no uri linhas 35 e 42 por não separar na entrada por ":". Logica na ide.
        static void Main( string[] args )
        {
            int d, h, m, s;
            int d2, h2, m2, s2;

            Console.Write("Dia: ");
            d = int.Parse(Console.ReadLine());
            string resp = Console.ReadLine();
            string[] sep = resp.Split(" : ");// alterar
            h = int.Parse(sep[0]);
            m = int.Parse(sep[1]);
            s = int.Parse(sep[2]);

            Console.Write("Dia: ");
            d2 = int.Parse(Console.ReadLine());
            string resp2 = Console.ReadLine();
            string[] sep2 = resp2.Split(" : ");// alterar
            h2 = int.Parse(sep2[0]);
            m2 = int.Parse(sep2[1]);
            s2 = int.Parse(sep2[2]);

            s = s2 - s;
            m = m2 - m;
            h = h2 - h;
            d = d2 - d;

            if (s < 0)
            {
                s += 60;
                m--;
            }
            if (m < 0)
            {
                m += 60;
                h--;
            }
            if (h < 0)
            {
                h += 24;
                d--;
            }
            Console.WriteLine($"{d} dia(s)\n" +
                              $"{h} hora(s)\n" +
                              $"{m} minuto(s)\n" +
                              $"{s} segundo(s)");
        }
    }
}
