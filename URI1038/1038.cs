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

            string[] valores = Console.ReadLine().Split();
            int codigo = int.Parse(valores[0]);
            int quantidade = int.Parse(valores[1]);
            double total = 0;

            switch(codigo){
            case 1: 
                total = quantidade * 4.00;
                break;
            case 2: 
                total = quantidade * 4.50;
                break;
            case 3: 
                total = quantidade * 5.00;
                break;
            case 4: 
                total = quantidade * 2.00;
                break;
            case 5: 
                total = quantidade * 1.50;
                break;
            }

            Console.WriteLine($"Total: R$ {total:F2}");
        }
    }
}