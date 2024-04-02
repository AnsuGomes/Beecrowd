using System.Globalization;
using System;

namespace URI
{
	class Program
	{
		static void Main()
		{
			CultureInfo culture = new CultureInfo("en-US");
			NumberFormatInfo numberFormat = culture.NumberFormat;
			CultureInfo.CurrentCulture = culture;
			
			double salarioInicial = double.Parse(Console.ReadLine());
			double reajusteGanho;
			int percentual;

			if (salarioInicial > 0 && salarioInicial <= 400)
			{
				percentual = 15;
				reajusteGanho = (salarioInicial * percentual)/ 100;
				Console.WriteLine($"Novo salario: {salarioInicial + reajusteGanho:F2}");
				Console.WriteLine($"Reajuste ganho: {reajusteGanho:F2}");
				Console.WriteLine($"Em percentual: {percentual} %");
			}
			else if (salarioInicial > 400 && salarioInicial <= 800)
			{
				percentual = 12;
				reajusteGanho = (salarioInicial * percentual)/ 100;
				Console.WriteLine($"Novo salario: {salarioInicial + reajusteGanho:F2}");
				Console.WriteLine($"Reajuste ganho: {reajusteGanho:F2}");
				Console.WriteLine($"Em percentual: {percentual} %");
			}
			else if (salarioInicial > 800 && salarioInicial <= 1200)
			{
				percentual = 10;
				reajusteGanho = (salarioInicial * percentual)/ 100;
				Console.WriteLine($"Novo salario: {salarioInicial + reajusteGanho:F2}");
				Console.WriteLine($"Reajuste ganho: {reajusteGanho:F2}");
				Console.WriteLine($"Em percentual: {percentual} %");
			}
			else if (salarioInicial > 1200 && salarioInicial <= 2000)
			{
				percentual = 7;
				reajusteGanho = (salarioInicial * percentual)/ 100;
				Console.WriteLine($"Novo salario: {salarioInicial + reajusteGanho:F2}");
				Console.WriteLine($"Reajuste ganho: {reajusteGanho:F2}");
				Console.WriteLine($"Em percentual: {percentual} %");
			}
			else 
			{	
				percentual = 4;
				reajusteGanho = (salarioInicial * percentual)/ 100;
				Console.WriteLine($"Novo salario: {salarioInicial + reajusteGanho:F2}");
				Console.WriteLine($"Reajuste ganho: {reajusteGanho:F2}");
				Console.WriteLine($"Em percentual: {percentual} %");
			}
		}    
	}
}