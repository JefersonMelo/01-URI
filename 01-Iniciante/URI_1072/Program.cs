using System;

namespace URI_1072
{
    class Program
    {
        /*
        Leia um valor inteiro N. Este valor será a quantidade de valores inteiros X que serão lidos em seguida.
        Mostre quantos destes valores X estão dentro do intervalo [10,20] e quantos estão fora do intervalo, mostrando essas informações.
        Entrada: A primeira linha da entrada contém um valor inteiro N (N < 10000), que indica o número de casos de teste.
        Cada caso de teste a seguir é um valor inteiro X (-107 < X <107).
        Saída: Para cada caso, imprima quantos números estão dentro (in) e quantos valores estão fora (out) do intervalo.
        Exemplo de Entrada 	Exemplo de Saída
        4                   2 in
        14                  2 out 
        123
        10
        -25
         */

        static void Main( string[] args )
        {
            int inn = 0, outt = 0, n, x;
            n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                x = int.Parse(Console.ReadLine());
                if (x >= 10 && x <= 20 )
                {
                    inn++;
                }
                if (x < 10 || x > 20)
                {
                    outt++;
                }
            }
            Console.WriteLine($"{inn} in");
            Console.WriteLine($"{outt} out");
        }
    }
}
