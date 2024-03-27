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

            int funcionarioId = int.Parse(Console.ReadLine());
            int horasTrabalhadas = int.Parse(Console.ReadLine());
            double salario = double.Parse(Console.ReadLine());

            Console.WriteLine($"NUMBER = {funcionarioId}\nSALARY = U$ {horasTrabalhadas * salario:F2}");
        }
    }
}