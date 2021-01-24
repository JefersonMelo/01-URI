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
        // Erro no Uri. ide ok.
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
                    if (sss == "onivoro")
                    {
                        s = "pomba";
                    }
                }
                if (ss == "mamifero")
                {
                    if (sss == "onivoro")
                    {
                        s = "homem";
                    }
                    if (s == "herbivoro")
                    {
                        s = "vaca";
                    }
                }
            }
            if (s == "invertebrado")
            {
                if (ss == "inseto")
                {
                    if (sss == "hematofago")
                    {
                        s = "pulga";
                    }
                    if (sss == "herbivoro")
                    {
                        s = "lagarta";
                    }
                }
                if (ss == "anelideo")
                {
                    if (sss == "onivoro")
                    {
                        s = "minhoca";
                    }
                    if (sss == "hemafogo")
                    {
                        s = "sanguessuga";
                    }
                }
            }
            Console.WriteLine(s);
        }
    }
}
