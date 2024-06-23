using System.Globalization;
using System.Collections.Generic;

namespace URI
{
	class Program
	{
		static void Main()
		{
			int N = int.Parse(Console.ReadLine());
			
			for(int i = 0; i <= 10000; i++)
			{
				if(i % N == 2)
					Console.WriteLine(i);
			}
		}
	}
}