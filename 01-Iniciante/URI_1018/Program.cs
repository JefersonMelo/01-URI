using System;

namespace URI_1018
{
    class Program
    {
        static void Main(string[] args)
        {
            int v = int.Parse(Console.ReadLine());
            Console.WriteLine(v);

            Console.WriteLine(v / 100 + " nota(s) de R$ 100,00");//576
            v %= 100;//76
            Console.WriteLine(v / 50 + " nota(s) de R$ 50,00");//76
            v %= 50;//26
            Console.WriteLine(v / 20 + " nota(s) de R$ 20,00");//26
            v %= 20;//6
            Console.WriteLine(v / 10 + " nota(s) de R$ 10,00");//6
            v %= 10;//0
            Console.WriteLine(v / 5 + " nota(s) de R$ 5,00");//6
            v %= 5;//1
            Console.WriteLine(v / 2 + " nota(s) de R$ 2,00");//1
            v %= 2;//0
            Console.WriteLine(v + " nota(s) de R$ 1,00");//1
        }
    }
}
