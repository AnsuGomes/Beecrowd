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
				valores[i] = int.Parse(input[i]); 
			}

			if(valores[0] % valores[1] == 0 || valores[1] % valores[0] == 0)
				Console.WriteLine("Sao Multiplos");
			else
				Console.WriteLine("Nao sao Multiplos");	
		}    
	}
}