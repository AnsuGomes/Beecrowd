using System.Collections.Generic;
using System.Globalization;
using System;

class URI
{
  static void Main()
  {
    string[] inicioData = Console.ReadLine().Split(' ');
    int dia1 = int.Parse(inicioData[1]);

    string[] inicioTempo = Console.ReadLine().Split(':');
    int horaInicial = int.Parse(inicioTempo[0]);
    int minutoInicial = int.Parse(inicioTempo[1]);
    int segundoInicial = int.Parse(inicioTempo[2]);

    string[] fimData = Console.ReadLine().Split(' ');
    int dia2 = int.Parse(fimData[1]);

    string[] fimTempo = Console.ReadLine().Split(':');
    int horaFinal = int.Parse(fimTempo[0]);
    int minutoFinal = int.Parse(fimTempo[1]);
    int segundoFinal = int.Parse(fimTempo[2]);

    TimeSpan duracao = new DateTime(1, 1, dia2, horaFinal, minutoFinal, segundoFinal) 
                     - new DateTime(1, 1, dia1, horaInicial, minutoInicial, segundoInicial);

    Console.WriteLine($"{duracao.Days} dia(s)");
    Console.WriteLine($"{duracao.Hours} hora(s)");
    Console.WriteLine($"{duracao.Minutes} minuto(s)");
    Console.WriteLine($"{duracao.Seconds} segundo(s)");
  }
}