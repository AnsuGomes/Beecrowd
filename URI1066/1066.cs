using System.Collections.Generic;
using System.Globalization;
using System;

class URI
{
  static void Main()
  {
    int[] valores = new int[5];

    List<double> par = new List<double>();
    List<double> impar = new List<double>();
    List<double> negativo = new List<double>();
    List<double> positivo = new List<double>();

    for (int i = 0; i < 5; i++)
    {
      valores[i] = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

      if(valores[i] % 2 == 0)
        par.Add(valores[i]);
      else
        impar.Add(valores[i]);

      if(valores[i] > 0)
        positivo.Add(valores[i]);  
      else if(valores[i] < 0)
        negativo.Add(valores[i]);   
    }

    Console.WriteLine($"{par.Count} valor(es) par(es)");
    Console.WriteLine($"{impar.Count} valor(es) impar(es)");
    Console.WriteLine($"{positivo.Count} valor(es) positivo(s)");
    Console.WriteLine($"{negativo.Count} valor(es) negativo(s)");
  }
}