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

    Dictionary<int, string> dddsEstados = new Dictionary<int, string>
    {
      {61, "Brasilia"},
      {71, "Salvador"},
      {11, "Sao Paulo"},
      {21, "Rio de Janeiro"},
      {32, "Juiz de Fora"},
      {19, "Campinas"},
      {27, "Vitoria"},
      {31, "Belo Horizonte"}
    };

    int input = int.Parse(Console.ReadLine());

    if (!dddsEstados.ContainsKey(input))
      Console.WriteLine("DDD nao cadastrado");
    else{
      Console.WriteLine($"{dddsEstados[input]}");
    }
  }
}