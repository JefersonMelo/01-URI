using System;
using System.Globalization;
namespace URI_1045
{
    class Program
    {
        /*
        Leia 3 valores de ponto flutuante A, B e C e ordene-os em ordem decrescente, de modo que o lado A representa o maior dos 3 lados. 
        A seguir, determine o tipo de triângulo que estes três lados formam, com base nos seguintes casos, sempre escrevendo uma mensagem adequada:
            se A ≥ B+C, apresente a mensagem: NAO FORMA TRIANGULO
            se A2 = B2 + C2, apresente a mensagem: TRIANGULO RETANGULO
            se A2 > B2 + C2, apresente a mensagem: TRIANGULO OBTUSANGULO
            se A2 < B2 + C2, apresente a mensagem: TRIANGULO ACUTANGULO
            se os três lados forem iguais, apresente a mensagem: TRIANGULO EQUILATERO
            se apenas dois dos lados forem iguais, apresente a mensagem: TRIANGULO ISOSCELES
        Entrada: A entrada contem três valores de ponto flutuante de dupla precisão A (0 < A) , B (0 < B) e C (0 < C).
        Saída: Imprima todas as classificações do triângulo especificado na entrada.
        Exemplos de Entrada 	Exemplos de Saída
        7.0 5.0 7.0             TRIANGULO ACUTANGULO
                                TRIANGULO ISOSCELES
	
        6.0 6.0 10.0            TRIANGULO OBTUSANGULO
                                TRIANGULO ISOSCELES 
         */

        static void Main( string[] args )
        {
            string[] s = Console.ReadLine().Split(' ');
            double a, b, c, aux;
            a = double.Parse(s[0], CultureInfo.InvariantCulture);
            b = double.Parse(s[1], CultureInfo.InvariantCulture);
            c = double.Parse(s[2], CultureInfo.InvariantCulture);

            if (a > b && a > c && c > b)
            {
                aux = b;
                b = c;
                c = aux;
            }
            if (b > a && b > c)
            {
                aux = a;
                a = b;
                b = aux;

                if (c > b)
                {
                    aux = c;
                    c = b;
                    b = aux;
                }
            }
            if (c > a && c > b)
            {
                aux = a;
                a = c;
                c = aux;

                if (c > b)
                {
                    aux = c;
                    c = b;
                    b = aux;
                }
            }
            //Console.WriteLine($"A:{a} B:{b} C:{c}\n");
            if (a >= (b + c)) { Console.WriteLine("NAO FORMA TRIANGULO"); }
            else if (a * a == (b * b + c * c)) { Console.WriteLine("TRIANGULO RETANGULO"); }
            else if (a * a > (b * b + c * c)) { Console.WriteLine("TRIANGULO OBTUSANGULO"); }
            else { Console.WriteLine("TRIANGULO ACUTANGULO"); }
            if (a == b && b == c) { Console.WriteLine("TRIANGULO EQUILATERO"); }
            else if (a == b || a == c || b == c) { Console.WriteLine("TRIANGULO ISOSCELES"); }
        }
    }
}
