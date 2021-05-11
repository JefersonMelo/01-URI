using System;

namespace URI_2554
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] line = Console.ReadLine().Split(' ');
            int totalDePessoas = int.Parse(line[0]);
            int totalDeDatas = int.Parse(line[1]);

            string dataConsiderada = "Pizza antes de FdI";
            bool swp = true;
            string[] entradaDataConfirmacao;
            while ( !string.IsNullOrEmpty(line[0]) )
            {
                for ( int i = 0; i < totalDeDatas; i++ )
                {
                    entradaDataConfirmacao = Console.ReadLine().Split(' ');
                    bool bol = true;

                    for ( int j = 1; j <= totalDePessoas; j++ )
                    {
                        if ( int.Parse(entradaDataConfirmacao[j]) != 1 )
                        {
                            bol = false;
                        }
                    }

                    if ( bol && swp )
                    {
                        swp = false;
                        dataConsiderada = entradaDataConfirmacao[0];
                    }
                }
                Console.WriteLine(dataConsiderada.Trim());
            }
        }
    }
}

/*
* string[] line = Console.ReadLine().Split(' ');
//string dataConsiderada, dataAux = "";
DateTime dataConsiderada = DateTime.Now; //verificar datetime
int cont, totalDePessoasQuePodemComparecer = 0;
DateTime dataAux = new DateTime();

while ( !string.IsNullOrEmpty(line[0]) )
{
                
int totalDePessoas = int.Parse(line[0]);
int totalDeDatas = int.Parse(line[1]);

for ( int i = 0; i < totalDeDatas; i++ )
{
cont = 0;
string[] entradaDataConfirmacao = Console.ReadLine().Split(' ');
//dataConsiderada = entradaDataConfirmacao[0];

for ( int j = 1; j < entradaDataConfirmacao.Length; j++ )
{
int aux = int.Parse(entradaDataConfirmacao[j]);
if ( aux == 1 )
{
cont++;
if ( cont == totalDePessoas )
{

if ( dataConsiderada > DateTime.Parse(entradaDataConfirmacao[0]) )
{
dataConsiderada = DateTime.Parse(entradaDataConfirmacao[0]);
}
//dataAux = dataConsiderada;
totalDePessoasQuePodemComparecer = cont;
}
}
}
}
if ( totalDePessoasQuePodemComparecer == totalDePessoas )
{
Console.WriteLine(dataConsiderada.ToString("d'/'MM'/'yyyy"));
}
else
{
Console.WriteLine("Pizza antes de FdA");
}
line = Console.ReadLine().Split(' ');
} 

    
*/