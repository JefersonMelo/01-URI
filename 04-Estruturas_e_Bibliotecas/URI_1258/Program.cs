using System;
using System.Collections.Generic;
using System.Linq;

namespace URI_1258
{
    /*
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
        static Camiseta camisa = new Camiseta();
        static void Main(string[] args)
        {
            string cor;
            char tamanho;
            string nomePessoa;

            int qtdEntradas = int.Parse(Console.ReadLine());
            do
            {
                while ( qtdEntradas > 0 )
                {
                    nomePessoa = Console.ReadLine();
                    string[] camiseta = Console.ReadLine().Split();
                    cor = camiseta[0];
                    tamanho = char.Parse(camiseta[1]);
                    Camiseta novaCamiseta = new Camiseta(nomePessoa, cor, tamanho);
                    camisa.Insere(novaCamiseta);
                    qtdEntradas--;
                }

                qtdEntradas = int.Parse(Console.ReadLine());

            } while ( qtdEntradas != 0 );

            var lista = camisa.Listar();
            IEnumerable<Camiseta> ordem = lista.OrderBy(cor => cor.Cor);//.OrderByDescending(tamanho => tamanho.Tamanho).OrderBy(nome => nome.NomePessoa);

            foreach ( var item in ordem )
            {
                Console.WriteLine(item);
            }
        }

        public class Camiseta
        {
            private string cor;
            private char tamanho;
            private string nomePessoa;

            List<Camiseta> listCamiseta = new List<Camiseta>();

            public Camiseta( ) { }

            public Camiseta(string nomePessoa, string cor, char tamanho)
            {
                this.cor = cor;
                this.tamanho = tamanho;
                this.nomePessoa = nomePessoa;
            }

            public string Cor { get => cor; set => cor = value; }
            public char Tamanho { get => tamanho; set => tamanho = value; }
            public string NomePessoa { get => nomePessoa; set => nomePessoa =  value ; }

            public void Insere(Camiseta objeto)
            {
                listCamiseta.Add(objeto);
            }

            public List<Camiseta> Listar( )
            {
                //IEnumerable<Camiseta> ordem = lista.OrderBy(cor => cor.Cor);
                return listCamiseta;
            }

            public override string ToString( )
            {
                return $"{cor} {tamanho} {nomePessoa}";
            }
        }
    }
}
