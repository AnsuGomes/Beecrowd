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

            string[] valores  = Console.ReadLine().Split();
            
            double A = double.Parse(valores[0]);
            double B = double.Parse(valores[1]);
            double C = double.Parse(valores[2]);

            double areaTraingulo = (A * C) / 2;
            Console.WriteLine($"TRIANGULO: {areaTraingulo:F3}");

            double areaCirculo = 3.14159 * Math.Pow(C, 2);
            Console.WriteLine($"CIRCULO: {areaCirculo:F3}");

            double areaTrapezio = ((A + B) * C) / 2;
            Console.WriteLine($"TRAPEZIO: {areaTrapezio:F3}");

            double areaQuadrado = Math.Pow(B, 2);
            Console.WriteLine($"QUADRADO: {areaQuadrado:F3}");

            double areaRetangulo = A * B;
            Console.WriteLine($"RETANGULO: {areaRetangulo:F3}");
        }
    }
}