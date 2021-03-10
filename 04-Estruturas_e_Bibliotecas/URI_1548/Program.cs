using System;
using System.Collections.Generic;

namespace URI_1548
{
    class Program
    {
        /*
        Na escola onde você estuda, a hora do recreio é a mais aguardada pela grande maioria dos alunos. 
        Não só porque as vezes as aulas são cansativas, mas sim porque a merenda servida é muito boa, 
        preparada por um chefe italiano muito caprichoso. Quando bate o sinal para a hora do recreio, 
        todos os alunos saem correndo da sua sala para chegar o mais cedo possível na cantina, tanta é a 
        vontade de comer. Um de seus professores notou, porém, que havia ali uma oportunidade.
        Utilizando um sistema de recompensa, seu professor de matemática disse que a ordem da fila para se 
        servir será dada não pela ordem de chegada, mas sim pela soma das notas obtidas em sala de aula. Assim, 
        aqueles com maior nota poderão se servir antes daqueles que tem menor nota.
        Sua tarefa é simples: dada a ordem de chegada dos alunos na cantina, e as suas respectivas notas na 
        matéria de matemática, reordene a fila de acordo com as notas de matemática, e diga quantos alunos não 
        precisaram trocar de lugar nessa reordenação.
        Entrada: A primeira linha contém um inteiro N, indicando o número de casos de teste a seguir.
        Cada caso de teste inicia com um inteiro M (1 ≤ M ≤ 1000), indicando o número de clientes. Em seguida haverá 
        M inteiros distintos Pi (1 ≤ Pi ≤ 1000), onde o i-ésimo inteiro indica o número recebido via sms do i-ésimo cliente.
        Os inteiros acima são dados em ordem de chegada, ou seja, o primeiro inteiro diz respeito ao primeiro cliente 
        a chegar na fila, o segundo inteiro diz respeito ao segundo cliente, e assim sucessivamente.
        Saída: Para cada caso de teste imprima uma linha, contendo um inteiro, indicando o número de clientes que não 
        precisaram trocar de lugar mesmo após a fila ser reordenada.
        Exemplo de Entrada 	    Exemplo de Saída
        3                       
        3
        100 80 90               1
        4                       
        100 120 30 50           0
        4   
        100 90 30 25            4
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
