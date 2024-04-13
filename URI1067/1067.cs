using System.Globalization;
using System;

namespace URI
{
	class Program
	{
		static void Main()
		{
			int impar = int.Parse(Console.ReadLine());
			
			for(int i = 1; i <= impar; i++)		
			{
				if(i % 2 == 1)
					Console.WriteLine(i);
			}	
		}
	}
}