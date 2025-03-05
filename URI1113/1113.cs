using System;
using System.Globalization;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Lista para armazenar os resultados.
        List<string> results = new List<string>();
        
        // Loop infinito.
        while (true)
        {
            // Lê os valores de X e Y.
            string[] valores = Console.ReadLine().Split(' ');
            int X = int.Parse(valores[0]);
            int Y = int.Parse(valores[1]);

            // Verifica se X e Y são iguais, se forem, encerra o programa.
            if (X == Y)
                break;

            // Verifica se os valores estão em ordem crescente ou decrescente.
            if (X < Y)
                results.Add("Crescente");
            else
                results.Add("Decrescente");
        }
        
        // Exibe a mensagem de encerramento.
        foreach (var result in results)
            Console.WriteLine(result);
    }
}