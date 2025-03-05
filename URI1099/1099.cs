using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        // Lê o número de casos de teste
        int n = int.Parse(Console.ReadLine());
        
        // Cria um array para armazenar os resultados
        int[] results = new int[n];
        
        // Para cada caso de teste
        for (int i = 0; i < n; i++)
        {
            // Lê os valores de x e y
            string[] valores = Console.ReadLine().Split(' ');
            int x = int.Parse(valores[0]);
            int y = int.Parse(valores[1]);
            
            // Soma os números ímpares entre x e y
            int somaImpares = 0;
            
            // Garante que x é menor que y
            if (x > y)
            {
                int temp = x;
                x = y;
                y = temp;
            }
                
            // Soma os números ímpares entre x e y   
            for (int j = x + 1; j < y; j++)
            {
                if (j % 2 != 0)
                    somaImpares += j;
            }

            // Armazena o resultado
            results[i] = somaImpares;
        }
        
        // Exibe os resultados
        foreach (var result in results)
            Console.WriteLine(result);
    }
}