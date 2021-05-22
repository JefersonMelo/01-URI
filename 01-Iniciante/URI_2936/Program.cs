using System;

namespace URI_2936
{
    class Program
    {
        static void Main(string[] args)
        {
            int Curupira = 300,
                Boitatah = 1500,
                Boto = 600,
                Mapinguari = 1000,
                Iara = 150,
                DonaChica = 225,
                porcao;

            int i = 1;
            while (i <= 5)
            {
                porcao = int.Parse(Console.ReadLine());
                if (i == 1) { Curupira *= porcao; }
                else if (i == 2) { Boitatah *= porcao; }
                else if (i == 3) { Boto *= porcao; }
                else if (i == 4) { Mapinguari *= porcao; }
                else if (i == 5) { Iara *= porcao; }
                i++;
            }
            int soma = Curupira + Boitatah + Boto + Mapinguari + Iara + DonaChica;
            Console.WriteLine(soma);
        }
    }
}
