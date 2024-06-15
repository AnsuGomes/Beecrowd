using System.Globalization;
using System;

namespace URI
{
	class Program
	{
		static void Main()
		{
			int x = int.Parse(Console.ReadLine());
			int y = int.Parse(Console.ReadLine());
			
			int maior = x > y ? x : y;
			int menor = x < y ? x : y;
			int somaImpares = 0;
			
			for (int i = menor + 1; i < maior; i++)
			{
				if(IsImpar(i))
					somaImpares += i;				
			}	
				
			Console.WriteLine(somaImpares);
		}
		
		static bool IsImpar(int i)
		{
			return i % 2 != 0;
		}
	}
}