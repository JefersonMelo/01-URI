using System;

namespace URI_1046
{
    class Program
    {
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
