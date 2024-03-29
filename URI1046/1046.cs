using System;
using System.Globalization;

namespace URI
{
	class URI
	{
		static void Main()
		{
			CultureInfo culture = new CultureInfo("en-US");
			NumberFormatInfo numberFormat = culture.NumberFormat;
			CultureInfo.CurrentCulture = culture;

			string[] input = Console.ReadLine().Split();

			int[] valores = new int[2];

			for (int i = 0; i < 2; i++)
			{
				valores[i] = int.Parse(input[i], CultureInfo.InvariantCulture);
			}

			if(valores[0] == valores[1])
				Console.WriteLine($"O JOGO DUROU {24 + (-valores[0] + valores[1])} HORA(S)");
			else if(valores[0] <= valores[1])	
				Console.WriteLine($"O JOGO DUROU {valores[1] - valores[0]} HORA(S)");
			else
				Console.WriteLine($"O JOGO DUROU {24 + (-valores[0] + valores[1])} HORA(S)");	
		}    
	}
}