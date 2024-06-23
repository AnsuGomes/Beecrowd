using System.Globalization;
using System.Collections.Generic;

namespace URI
{
	class Program
	{
		static void Main()
		{
			int N = int.Parse(Console.ReadLine());
			int[] valores = new int[N];
			List<string> result = new List<string>();
			
			for (int i = 0; i < N; i++)
			{
				valores[i] = int.Parse(Console.ReadLine());
			}
			
			for(int i = 0; i < N; i++)
			{
				if(valores[i] == 0)	
					result.Add("NULL");
				else
				{
					string imparOrPar = (valores[i] % 2 == 0) ? "EVEN" : "ODD";
					
					string negativeOrPositive = (valores[i] > 0) ? "POSITIVE" : "NEGATIVE";
					
					result.Add($"{imparOrPar} {negativeOrPositive}");
				}	
			}
			
			foreach(string results in result)
			{
				Console.WriteLine(results);
			}
		}
	}
}