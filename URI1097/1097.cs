using System;

class Program
{
    static void Main()
    {
        // Loop para controlar o valor de I
        for (int i = 1; i <= 9; i += 2)
        {
            // Calcula o valor inicial de J com base em I
            int jInicial = 7 + (i - 1); // 7, 9, 11, 13, 15
            int jFinal = jInicial - 2;  // 5, 7, 9, 11, 13

            // Loop para controlar o valor de J
            for (int j = jInicial; j >= jFinal; j--)
            {
                // Exibe os valores de I e J
                Console.WriteLine($"I={i} J={j}");
            }
        }
    }
}