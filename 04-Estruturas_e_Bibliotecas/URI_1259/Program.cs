using System;
using System.Collections.Generic;
using System.Linq;

namespace URI_1259
{
    class Program
    {
        /*
         * https://pt.stackoverflow.com/questions/415521/unir-duas-listas-c
         * 
         */
        static void Main(string[] args)
        {
            
            int n = int.Parse(Console.ReadLine());
            int[] vet = new int[n];

            List<int> listPar = new List<int>();
            List<int> listImpar = new List<int>();

            for ( int i = 0; i < n; i++ )
            {
                vet[i] = int.Parse(Console.ReadLine());
            }

            for ( int i = 0; i < vet.Length; i++ )
            {
                if ( vet[i] % 2 == 0 )
                {
                    listPar.Add(vet[i]);
                }
                else
                {
                    listImpar.Add(vet[i]);
                }

            }
            listImpar.Sort();
            listImpar.Reverse();
            listPar.Sort();
            var listaConcatenada = listPar.Concat(listImpar);

            foreach ( var item in listaConcatenada )
            {
                Console.WriteLine(item);
            }
        }
    }
}
