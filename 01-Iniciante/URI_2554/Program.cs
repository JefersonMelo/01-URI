using System;

namespace URI_2554
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] line = Console.ReadLine().Split(' ');
            string dataConsiderada, dataAux = "";//DateTime dataConsiderada = new DateTime(); //verificar datetime
            int cont, totalDePessoasQuePodemComparecer = 0;
            //DateTime dataAux = new DateTime();

            while ( true )
            {
                if ( string.IsNullOrEmpty(line[0]) )
                    break;

                int totalDePessoas = int.Parse(line[0]);
                int totalDeDatas = int.Parse(line[1]);

                for ( int i = 0; i < totalDeDatas; i++ )
                {
                    cont = 0;
                    string[] entradaDataConfirmacao = Console.ReadLine().Split(' ');
                    dataConsiderada = entradaDataConfirmacao[0];//DateTime.Parse(entradaDataConfirmacao[0]);

                    for ( int j = 1; j < entradaDataConfirmacao.Length; j++ )
                    {
                        int aux = int.Parse(entradaDataConfirmacao[j]);
                        if ( aux == 1 )
                        {
                            cont++;
                            if ( cont == totalDePessoas )
                            {
                                dataAux = dataConsiderada;
                                totalDePessoasQuePodemComparecer = cont;
                            }
                        }
                    }
                }
                if ( totalDePessoasQuePodemComparecer == totalDePessoas )
                {
                    Console.WriteLine(dataAux/*.ToString("d/M/yyyy")*/);
                }
                else
                {
                    Console.WriteLine("Pizza antes de FdA");
                }
                line = Console.ReadLine().Split(' ');
            }
        }
    }
}

/*
 using System;

//continue a solução

public class pizzaria
{
  public static void Main()
  {
    string[] line = Console.ReadLine().Split(" ");
    int totalDePessoas = int.Parse(line[0]);
    int totalDeDatas =      ;
    
    string dataConsiderada = " ";
    
    for (int i = 0; i < totalDeDatas; i++)
    {
      int totalDePessoasQuePodemComparecer =    ;
      
      string[] entradaDataConfirmacao = Console.ReadLine().Split(" ");
      dataConsiderada = ;
      
      for (int j =  ; j <   ; j++)
      {
        
      }
      
      if (totalDePessoasQuePodemComparecer ==    )
      {
        Console.WriteLine(dataConsiderada);
        break;
      } 
      else if ( i + 1 >=       )
      {
        Console.WriteLine("Pizza antes de FdA");
      }
    }
  }
}
 */