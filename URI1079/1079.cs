using System.Globalization;
using System.Collections.Generic;
using System;
using System.Linq;

namespace URI
{
	class Program
	{
		static void Main()
		{
			int N = int.Parse(Console.ReadLine());

			for (int i = 1; i <= N; i++)
			{
				double[] valores = Console.ReadLine().Split().Select(double.Parse).ToArray();
				
				double mediaPonderada = (valores[0] * 2.0 + valores[1] * 3.0 + valores[2] * 5.0) / 10.0;
				
				Console.WriteLine($"{mediaPonderada:F1}");
			}
		}
	}
}