using System.Globalization;
using System;

namespace URI
{
	class Program
	{
		static void Main()
		{
			int impar = int.Parse(Console.ReadLine());
			
			int i = 0;
			
			while(i < 6) 
			{
				if(impar % 2 == 1)	
				{
					Console.WriteLine(impar);
					i++;
				}
				
				impar++;
			}
		}
	}
}