using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        // Configurando a cultura para garantir formatação correta de números
        CultureInfo culture = new CultureInfo("en-US");
        double i = 0;
        double j = 1;

        while (i <= 2)
        {
            for (int k = 0; k < 3; k++)
            {
                // Formatação com uma casa decimal
                string iFormatted = i.ToString("0.0", culture);
                string jFormatted = j.ToString("0.0", culture);

                // Verificando se i é um número inteiro (sem parte decimal)
                if (iFormatted.EndsWith(".0"))
                    Console.WriteLine($"I={iFormatted.Substring(0, 1)} J={jFormatted.Substring(0, 1)}");
				else
                    Console.WriteLine($"I={iFormatted} J={jFormatted}");
				
                j++;
            }
            j -= 3; // Reseta j para o valor inicial da próxima iteração
            j += 0.2; // Incrementa j em 0.2
            i += 0.2; // Incrementa i em 0.2
        }
    }
}
