using System;

namespace URI_1158
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int x, y, somarImpar = 0;

            while(n > 0)
            {
                string[] nums = Console.ReadLine().Split(' ');
                x = int.Parse(nums[0]);
                y = int.Parse(nums[1]);

                while(y > 0)
                {
                    if(x % 2 != 0)
                    {
                        somarImpar += x;
                        y--;
                    }
                    x++;
                }
                Console.WriteLine(somarImpar);
                somarImpar = 0;
                n--;
            }
        }
    }
}
