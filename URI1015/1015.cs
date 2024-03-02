using System;

namespace URI
{
    class URI
    {
        static void Main()
        {   
            CultureInfo culture = new CultureInfo("en-US");
            NumberFormatInfo numberFormat = culture.NumberFormat;
            CultureInfo.CurrentCulture = culture;

            string[] coordenada1 = Console.ReadLine().Split();
            string[] coordenada2 = Console.ReadLine().Split();

            double x1 = double.Parse(coordenada1[0]);
            double y1 = double.Parse(coordenada1[1]);

            double x2 = double.Parse(coordenada2[0]);
            double y2 = double.Parse(coordenada2[1]);

            Console.WriteLine($"{Math.Sqrt(Math.Pow(x2-x1,2) + Math.Pow(y2-y1,2)):F4}");
        }
    }
}