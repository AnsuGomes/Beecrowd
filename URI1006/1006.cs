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

            double nota1 = double.Parse(Console.ReadLine());
            double nota2 = double.Parse(Console.ReadLine());
            double nota3 = double.Parse(Console.ReadLine());

            nota1 *= 2;
            nota2 *= 3;
            nota3 *= 5;

            Console.WriteLine($"MEDIA = {(nota1 + nota2 + nota3) / 10:F1}");
        }
    }
}