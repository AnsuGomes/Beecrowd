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

            nota1 *= 3.5;
            nota2 *= 7.5;

            Console.WriteLine($"MEDIA = {(nota1 + nota2) / 11:F5}");
        }
    }
}