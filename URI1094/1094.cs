using System;
using System.Linq;
using System.Globalization;
using System.Collections.Generic;

namespace URI
{
	class Program
	{
		static void Main()
		{
			CultureInfo culture = new CultureInfo("en-US");
			NumberFormatInfo numberFormat = culture.NumberFormat;
			CultureInfo.CurrentCulture = culture;
			
			int n = int.Parse(Console.ReadLine());
			
			int totalCobaias = 0;
			int totalCoelhos = 0;
			int totalRatos = 0;
			int totalSapos = 0;
			
			for (int i = 0; i < n; i++)
			{
				string[] input = Console.ReadLine().Split(' ');
				int quantidade = int.Parse(input[0]);
				char tipo = char.Parse(input[1]);
				
				totalCobaias += quantidade;
				
				switch(tipo)
				{
					case 'C':
						totalCoelhos += quantidade;
						break;
					case 'R':
						totalRatos += quantidade;
						break;
					case 'S':
						totalSapos += quantidade;
						break;	
				}
			}
			
			double percentualCoelhos = (double)totalCoelhos / totalCobaias * 100.0;
			double percentualRatos = (double)totalRatos / totalCobaias * 100.0;
			double percentualSapos = (double)totalSapos / totalCobaias * 100.0;

			Console.WriteLine($"Total: {totalCobaias} cobaias");
			Console.WriteLine($"Total de coelhos: {totalCoelhos}");
			Console.WriteLine($"Total de ratos: {totalRatos}");
			Console.WriteLine($"Total de sapos: {totalSapos}");
			Console.WriteLine($"Percentual de coelhos: {percentualCoelhos:F2} %");
			Console.WriteLine($"Percentual de ratos: {percentualRatos:F2} %");
			Console.WriteLine($"Percentual de sapos: {percentualSapos:F2} %");
		}
	}
}