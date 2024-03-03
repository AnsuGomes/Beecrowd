using System;

namespace URI
{
    class URI
    {
        static void Main()
        {
            int kmPorHora = 12;
            double tempoGasto = double.Parse(Console.ReadLine());
            double velocidadeMedia = double.Parse(Console.ReadLine());

            Console.WriteLine($"{(tempoGasto * velocidadeMedia) / kmPorHora:F3}");
        }
    }
}