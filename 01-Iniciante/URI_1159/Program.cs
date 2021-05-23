using System;

namespace URI_1159
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int soma = 0;

            while(x != 0)
            {
                int qtd = 5;

                while(qtd > 0)
                {
                    if(x % 2 == 0)
                    {
                        soma += x;
                        qtd--;
                    }
                    x++;
                }
                Console.WriteLine(soma);
                soma = 0;
                x = int.Parse(Console.ReadLine());
            }
        }
    }
}
