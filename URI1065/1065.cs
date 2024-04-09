using System.Collections.Generic;
using System.Globalization;
using System;

class URI
{
  static void Main()
  {
    double[] valores = new double[5];

    List<double> par = new List<double>();

    for (int i = 0; i < 5; i++)
    {
      valores[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

      if(valores[i] % 2 == 0)
        par.Add(valores[i]);
    }

    Console.WriteLine($"{par.Count} valores positivos");
  }
}