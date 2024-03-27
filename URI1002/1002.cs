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

            double raio = double.Parse(Console.ReadLine());
            double pi = 3.14159;

            Console.WriteLine($"A={Math.Pow(raio, 2) * pi:F4}");
        }
    }
}