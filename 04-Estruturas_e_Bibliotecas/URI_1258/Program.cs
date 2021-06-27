using System;
using System.Collections.Generic;
using System.Linq;

namespace URI_1258
{
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