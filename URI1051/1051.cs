using System.Collections.Generic;
using System.Globalization;
using System;

class URI
{
  static void Main()
  {
    CultureInfo culture = new CultureInfo("en-US");
    NumberFormatInfo numberFormat = culture.NumberFormat;
    CultureInfo.CurrentCulture = culture;

    double salario = double.Parse(Console.ReadLine());

    if(salario <= 2000)
      Console.WriteLine("Isento");
    else if(salario >= 2000.01 && salario <= 3000)  
      Console.WriteLine($"R$ {(salario - 2000) * 0.08:F2}");
    else if(salario >= 3000.01 && salario <= 4500)  
      Console.WriteLine($"R$ {(salario - 3000) * 0.18 + 1000.00 * 0.08:F2}");
    else
      Console.WriteLine($"R$ {(salario - 4500) * 0.28 + 1500.00 * 0.18 + 1000.00 * 0.08:F2}");  
  }
}