using System;
using System.Collections.Generic;
using System.Linq;

namespace URI_2729
{
    class Program
    {
        /*
        https://docs.microsoft.com/pt-br/dotnet/api/system.linq.queryable.distinct?view=net-5.0
        https://docs.microsoft.com/pt-br/dotnet/framework/data/adonet/sql/linq/eliminate-duplicate-elements-from-a-sequence#:~:text=Use%20o%20operador%20de%20Distinct,duplicate%20elements%20from%20a%20sequence.
         */
        static void Main(string[] args)
        {
            string[] prods;
            List<string> list = new List<string>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                prods = Console.ReadLine().Split(' ');
                for (int j = 0; j < prods.Length; j++)
                {
                    list.Add(prods[j]);
                }
                list.Sort();
                IEnumerable<string> listLimpa = list.AsQueryable().Distinct();
                int a = listLimpa.Count();
                foreach (var item in listLimpa)
                {

                    if (a > 1)
                    {
                        Console.Write($"{item}");
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write($"{item}");
                    }

                    a--;
                }

                list.Clear();
                Console.WriteLine();

            }
        }
    }
}
