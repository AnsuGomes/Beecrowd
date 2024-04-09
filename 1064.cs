using System.Collections.Generic;
using System.Globalization;
using System;

class URI
{
  static void Main()
  {
    double[] valores = new double[6];

    List<double> positivos = new List<double>();

    double soma = 0;
    double average = 0;

    for (int i = 0; i < 6; i++)
    {
      valores[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

      if(valores[i] > 0)
        positivos.Add(valores[i]);
    }

    foreach (double valor in positivos) 
    {
      soma += valor;
    }

    average = soma / positivos.Count;

    Console.WriteLine($"{positivos.Count} valores positivos");
    Console.WriteLine($"{average.ToString("F1", CultureInfo.InvariantCulture)}");
  }
}