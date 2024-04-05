using System.Collections.Generic;
using System.Globalization;
using System;

class URI
{
  static void Main()
  {
	double[] valores = new double[6];

    List<double> positivos = new List<double>();

    for (int i = 0; i < 6; i++)
    {
      valores[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

      if(valores[i] > 0)
        positivos.Add(valores[i]);
    }

    Console.WriteLine($"{positivos.Count} valores positivos");
  }
}