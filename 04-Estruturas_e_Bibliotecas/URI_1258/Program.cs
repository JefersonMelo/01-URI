using System;
using System.Collections.Generic;
using System.Linq;

namespace URI_1258
{
    /*
     * https://urisolve.blogspot.com/2017/04/uri-solution-1258-t-shirts-in-c.html
     * 
     * https://www.w3schools.com/tryit/tryit.asp?filename=tryhtml_default
     * 
     * https://pt.stackoverflow.com/questions/5083/como-ordenar-lista-com-objeto-complexo-por-uma-de-suas-propriedades
     * 
     * https://docs.microsoft.com/pt-br/dotnet/api/system.collections.generic.list-1.sort?view=net-5.0
     * 
     * https://www.delftstack.com/pt/howto/csharp/how-to-sort-a-list-by-a-property-in-the-object-in-csharp/#:~:text=Usando%20o%20delegado-,Utilize%20o%20m%C3%A9todo%20OrderBy%20para%20ordenar%20uma%20lista%20por%20uma,ordenada%20pelo%20bem%20em%20quest%C3%A3o.
     * 
     * https://csharp.net-tutorials.com/pt/439/linq/organizando-dados-os-metodos-orderby-thenby/
     * 
     * https://docs.microsoft.com/pt-br/dotnet/csharp/programming-guide/concepts/linq/sorting-data
     * 
     */
    class Program
    {
        static void Main(string[] args)
        {
            List<Camiseta> listPedido = new List<Camiseta>();
            int qtdPedidos = int.Parse(Console.ReadLine());//Convert.ToInt32(qtdPedidos) ou !string.IsNullOrEmpty(line[0])
            string nome;

            do
            {
                while ( qtdPedidos > 0 )
                {
                    nome = Console.ReadLine();
                    string[] dadosCamisa = Console.ReadLine().Split();
                    listPedido.Add(new Camiseta
                    {
                        Nome = nome,
                        Cor = dadosCamisa[0],
                        Tamanho = char.Parse(dadosCamisa[1])
                    });
                    qtdPedidos--;
                }
                IEnumerable<Camiseta> ordenarList = from pedido in listPedido
                                                    orderby pedido.Cor ascending,
                                                    pedido.Tamanho descending,
                                                    pedido.Nome ascending
                                                    select pedido;
                foreach ( var item in ordenarList )
                {
                    Console.WriteLine(item);
                }

                qtdPedidos = int.Parse(Console.ReadLine());

                if ( qtdPedidos != 0 )
                {
                    Console.WriteLine();
                    listPedido.Clear();
                }

            } while ( qtdPedidos != 0 );
        }

        public class Camiseta
        {
            public string Cor { get; set; }
            public char Tamanho { get; set; }
            public string Nome { get; set; }

            public override string ToString( )
            {
                return $"{Cor} {Tamanho} {Nome}";
            }
        }
    }
}