using System;
using System.Globalization;

namespace URI
{
    class URI
    {
        static void Main()
        {
            CultureInfo culture = new CultureInfo("en-US");
            NumberFormatInfo numberFormat = culture.NumberFormat;
            CultureInfo.CurrentCulture = culture;

            string[] notas = Console.ReadLine().Split();

            double nota1 = double.Parse(notas[0]);
            double nota2 = double.Parse(notas[1]);
            double nota3 = double.Parse(notas[2]);
            double nota4 = double.Parse(notas[3]);

            nota1 *= 2;
            nota2 *= 3;
            nota3 *= 4;
            nota4 *= 1;

            double media = (nota1 + nota2 + nota3 + nota4) / 10;

            media = Math.Floor(media * 10) / 10; //arrendonda para baixo.

            if(media >= 7.0)
                Console.WriteLine($"Media: {media:F1}\nAluno aprovado.");

            else if (media < 5.0)
                Console.WriteLine($"Media: {media:F1}\nAluno reprovado.");    

            else {
                double nota5 = double.Parse(Console.ReadLine());

                double mediaRecuperacao = (media + nota5) / 2;

                Console.WriteLine($"Media: {media:F1}\nAluno em exame.\nNota do exame: {nota5:F1}");

                if (mediaRecuperacao >= 5.0)
                    Console.WriteLine($"Aluno aprovado.\nMedia final: {mediaRecuperacao:F1}");
                else
                     Console.WriteLine($"Aluno reprovado.\nMedia final: {mediaRecuperacao:F1}");   
            }    
        }
    }
}