using System;

namespace URI_1049
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine().ToLower();
            string ss = Console.ReadLine().ToLower();
            string sss = Console.ReadLine().ToLower();

            if (s == "vertebrado")
            {
                if (ss == "ave")
                {
                    if (sss == "carnivoro")
                    {
                        s = "aguia";
                    }
                    else { s = "pomba"; }
                }
                else
                {
                    if (sss == "onivoro")
                    {
                        s = "homem";
                    }
                    else { s = "vaca"; }
                }
            }
            else
            {
                if (ss == "inseto")
                {
                    if (sss == "hematofago")
                    {
                        s = "pulga";
                    }
                    else { s = "lagarta"; }
                }
                else
                {
                    if (sss == "onivoro")
                    {
                        s = "minhoca";
                    }
                    else { s = "sanguessuga"; }
                }
            }
            Console.WriteLine(s);
        }
    }
}
