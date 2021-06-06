using System;
using System.Collections.Generic;

namespace URI_1548
{
    class Program
    {
        /*
        https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1.reverse?redirectedfrom=MSDN&view=net-5.0#System_Collections_Generic_List_1_Reverse
        https://social.msdn.microsoft.com/Forums/pt-BR/a19997f5-47b8-4732-84c2-74ed8a2468e9/ordem-decrescente?forum=vscsharppt
        https://www.devmedia.com.br/forum/3-numeros-em-ordem-crescente-csharp/597322
         */
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] notas;
            int qtdEntradas;
            int numReordem = 0;
            List<int> list = new List<int>();

            for ( int i = 0; i < n; i++ )
            {
                qtdEntradas = int.Parse(Console.ReadLine());
                string[] s = Console.ReadLine().Split(' ');
                notas = new int[qtdEntradas];
                for ( int j = 0; j < qtdEntradas; j++ )
                {
                    notas[j] = int.Parse(s[j]);
                    list.Add(notas[j]);

                    if ( j == ( qtdEntradas - 1 ) )
                    {
                        list.Sort();
                        list.Reverse();
                        for ( int k = 0; k < list.Count; k++ )
                        {
                            if ( notas[k] == list[k] )
                            {
                                numReordem++;
                            }
                        }

                    }
                }
                Console.WriteLine(numReordem);
                numReordem = 0;
                list.Clear();
            }
        }
    }
}
