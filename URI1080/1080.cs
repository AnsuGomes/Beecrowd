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
			int maiorValue = int.MinValue;
			int posicao = -1;

			for (int i = 0; i < 100; i++)
			{
				int value = int.Parse(Console.ReadLine());

				if (value > maiorValue)
				{
					maiorValue = value;
					posicao = i + 1;
				}
			}

			Console.WriteLine(maiorValue);
			Console.WriteLine(posicao);
		}
	}
}