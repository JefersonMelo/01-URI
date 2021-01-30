using System;
using System.Globalization;

namespace URI_1040
{
    class Program
    {
        /*
        Leia quatro números (N1, N2, N3, N4), cada um deles com uma casa decimal, correspondente às quatro notas de um aluno. 
        Calcule a média com pesos 2, 3, 4 e 1, respectivamente, para cada uma destas notas e mostre esta média acompanhada pela 
        mensagem "Media: ". Se esta média for maior ou igual a 7.0, imprima a mensagem "Aluno aprovado.". Se a média calculada for 
        inferior a 5.0, imprima a mensagem "Aluno reprovado.". Se a média calculada for um valor entre 5.0 e 6.9, inclusive estas, 
        o programa deve imprimir a mensagem "Aluno em exame.".
        No caso do aluno estar em exame, leia um valor correspondente à nota do exame obtida pelo aluno. Imprima então a mensagem 
        "Nota do exame: " acompanhada pela nota digitada. Recalcule a média (some a pontuação do exame com a média anteriormente 
        calculada e divida por 2). e imprima a mensagem "Aluno aprovado." (caso a média final seja 5.0 ou mais ) ou "Aluno reprovado.", 
        (caso a média tenha ficado 4.9 ou menos). Para estes dois casos (aprovado ou reprovado após ter pego exame) apresente na última 
        linha uma mensagem "Media final: " seguido da média final para esse aluno.
        Entrada: A entrada contém quatro números de ponto flutuante correspendentes as notas dos alunos.
        Saída: Todas as respostas devem ser apresentadas com uma casa decimal. As mensagens devem ser impressas conforme a descrição do problema. 
        Não esqueça de imprimir o enter após o final de cada linha, caso contrário obterá "Presentation Error".
        Exemplo de Entrada 	Exemplo de Saída
        2.0 4.0 7.5 8.0     Media: 5.4
        6.4                 Aluno em exame.
                            Nota do exame: 6.4
                            Aluno aprovado.
                            Media final: 5.9
      
        2.0 6.5 4.0 9.0     Media: 4.8
                            Aluno reprovado.                 
         */
        // Não Foi Aprovado. ide ok.
        static void Main( string[] args )
        {
            double a, b, c, d;
            double n5, media;
            int peso = 10;
            string[] s = Console.ReadLine().Split(' ');
            a = Math.Round(double.Parse(s[0], CultureInfo.InvariantCulture) * 2.0);
            b = Math.Round(double.Parse(s[1], CultureInfo.InvariantCulture) * 3.0);
            c = Math.Round(double.Parse(s[2], CultureInfo.InvariantCulture) * 4.0);
            d = Math.Round(double.Parse(s[3], CultureInfo.InvariantCulture) * 1.0);

            media = (a + b + c + d) / peso;
            Console.WriteLine("Media: " + media.ToString("F1", CultureInfo.InvariantCulture));

            if (media > 5.0 && media < 7.0)
            {
                Console.WriteLine("Aluno em exame.");
                n5 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine("Nota do exame: " + n5.ToString(CultureInfo.InvariantCulture));
                media = (media + n5) / 2.0;

                if (media >= 5.0)
                {
                    Console.WriteLine("Aluno aprovado.");
                }
                else
                {
                    Console.WriteLine("Aluno reprovado.");
                }
                Console.WriteLine("Media final: " + media.ToString("F1", CultureInfo.InvariantCulture));
            }
            else
            {             
                if (media < 5.0)
                {
                    Console.WriteLine("Aluno reprovado.");
                }
                else if (media >= 7.0)
                {
                    Console.WriteLine("Aluno aprovado.");
                }
            }
        }
    }
}
