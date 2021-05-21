using System;

namespace URI_1061
{
    class Program
    {
        static void Main(string[] args)
        {

            int diaInicio, diaTermino, horaMomentoInicio, minutoMomentoInicio, segundoMomentoInicio;
            int horaMomentoTermino, minutoMomentoTermino, segundoMomentoTerminio;

            string[] dadosInicio = Console.ReadLine().Split();
            diaInicio = Convert.ToInt32(dadosInicio[1]);

            string[] dadosMomentoInicio = Console.ReadLine().Split(':');
            horaMomentoInicio = Convert.ToInt32(dadosMomentoInicio[0]);
            minutoMomentoInicio = Convert.ToInt32(dadosMomentoInicio[1]);
            segundoMomentoInicio = Convert.ToInt32(dadosMomentoInicio[2]);


            string[] dadosTermino = Console.ReadLine().Split();
            diaTermino = Convert.ToInt32(dadosTermino[1]);

            string[] dadosMomentoTermino = Console.ReadLine().Split(':');
            horaMomentoTermino = Convert.ToInt32(dadosMomentoTermino[0]);
            minutoMomentoTermino = Convert.ToInt32(dadosMomentoTermino[1]);
            segundoMomentoTerminio = Convert.ToInt32(dadosMomentoTermino[2]);


            int transformaSegundosInicio = segundoMomentoInicio + (minutoMomentoInicio * 60) + (horaMomentoInicio * 3600) + (diaInicio * 86400);
            int transformaSegundosTermino = segundoMomentoTerminio + (minutoMomentoTermino * 60) + (horaMomentoTermino * 3600) + (diaTermino * 86400);

            int somaTotalSegundos = transformaSegundosTermino - transformaSegundosInicio;
            int W = somaTotalSegundos / 86400;
            somaTotalSegundos %= 86400;
            int X = somaTotalSegundos / 3600;
            somaTotalSegundos %= 3600;
            int Y = somaTotalSegundos / 60;
            somaTotalSegundos %= 60;
            int Z = somaTotalSegundos;

            Console.WriteLine($"{W} dia(s)\n" +
                              $"{X} hora(s)\n" +
                              $"{Y} minuto(s)\n" +
                              $"{Z} segundo(s)");


        }
    }
}
