using System;

class Program
{
    static void Main()
    {
        // Loop para controlar o valor de I
        for (int i = 1; i <= 9; i += 2)
        {
            // Loop para controlar o valor de J
            for (int j = 7; j >= 5; j--)
            {
                // Exibe os valores de I e J
                Console.WriteLine($"I={i} J={j}");
            }
        }
    }
}