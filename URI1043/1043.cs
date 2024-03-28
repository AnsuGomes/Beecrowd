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

			double[] valores = new double[3];

			for (int i = 0; i < 3; i++)
			{
				valores[i] = double.Parse(input[i]); 
			}

			if(valores[0] + valores[1] > valores[2] && valores[1] + valores[2] > valores[0] && valores[0] + valores[2] > valores[1])
			{
				double perimetro = valores[0] + valores[1] + valores[2]; // Perimetro do triângulo.
				Console.WriteLine($"Perimetro = {perimetro:F1}"); 
			}
			else
			{
				double area = ((valores[0] + valores[1]) * valores[2]) / 2;  // Área do trapézio.
				Console.WriteLine($"Area = {area:F1}");
			}
		}    
	}
}