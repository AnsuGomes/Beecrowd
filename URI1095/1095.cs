using System.Globalization;
using System.Collections.Generic;
using System;

namespace URI
{
	class Program
	{
		static void Main()
		{
			int i = 1, j = 60;

            while (j >= 0){
                Console.WriteLine($"I={i} J={j}");
                i += 3;
                j -= 5;
            }
		}
	}
}