using System.Globalization;
using System;

namespace URI
{
	class Program
	{
		static void Main()
		{
			int N = int.Parse(Console.ReadLine());
			
			for(int i = 0; i <= N; i++)
			{
				if((i % 2 == 0) && (i > 0))
					Console.WriteLine($"{i}^{2} = {Math.Pow(i, 2)}");
			}
		}
	}
}