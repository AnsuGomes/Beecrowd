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

            string[] input = Console.ReadLine().Split();

            int[] valores = new int[3];

            for (int i = 0; i < 3; i++)
            {
                valores[i] = int.Parse(input[i]); // Converte string para int.
            }

            int[] valoresOriginais = new int[3]; // Copia o array para manter a ordem original.
            Array.Copy(valores, valoresOriginais, 3);

            Array.Sort(valores); // Ordena os valores em ordem crescente.

            foreach (int valor in valores) {
                Console.WriteLine(valor);  // Mostra o valor em order crescente.
            }

            Console.WriteLine();

            foreach (int valor in valoresOriginais) {
                Console.WriteLine(valor);  // Mostra o valor lido.
            }  
        }    
    }
}