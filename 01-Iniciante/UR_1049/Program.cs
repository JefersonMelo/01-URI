using System;

namespace UR_1049
{
    class Program
    {
        /*
        Neste problema, você deverá ler 3 palavras que definem o tipo de animal possível segundo o esquema abaixo, da esquerda para a direita.  
        Em seguida conclua qual dos animais seguintes foi escolhido, através das três palavras fornecidas.
        Entrada: A entrada contém 3 palavras, uma em cada linha, necessárias para identificar o animal segundo a figura acima, com todas as letras minúsculas.
        Saída: Imprima o nome do animal correspondente à entrada fornecida.
        Exemplos de Entrada 	Exemplos de Saída
        vertebrado              homem
        mamifero
        onivoro
	
        vertebrado              aguia
        ave
        carnivoro
         */

        static void Main( string[] args )
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
                    else //if (sss == "onivoro")
                    {
                        s = "pomba";
                    }
                }
                else //if (ss == "mamifero")
                {
                    if (sss == "onivoro")
                    {
                        s = "homem";
                    }
                    else //if (sss == "herbivoro")
                    {
                        s = "vaca";
                    }
                }
            }
            else //if (s == "invertebrado")
            {
                if (ss == "inseto")
                {
                    if (sss == "hematofago")
                    {
                        s = "pulga";
                    }
                    else //if (sss == "herbivoro")
                    {
                        s = "lagarta";
                    }
                }
                else //if (ss == "anelideo")
                {
                    if (sss == "onivoro")
                    {
                        s = "minhoca";
                    }
                    else //if (sss == "hemafogo")
                    {
                        s = "sanguessuga";
                    }
                }
            }
            Console.WriteLine(s);
        }
    }
}
