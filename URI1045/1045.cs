using System;
using System.Globalization;

namespace URI
{
	class URI
	{
		static void Main()
		{
			CultureInfo culture = new CultureInfo("en-US");
			NumberFormatInfo numberFormat = culture.NumberFormat;
			CultureInfo.CurrentCulture = culture;

			string[] input = Console.ReadLine().Split();

			double[] valores = new double[3];

			for (int i = 0; i < 3; i++)
            {
                valores[i] = double.Parse(input[i], CultureInfo.InvariantCulture);
            }

            Array.Sort(valores);
            Array.Reverse(valores);

            double A = valores[0];
            double B = valores[1];
            double C = valores[2];

            if (A >= B + C)
                Console.WriteLine("NAO FORMA TRIANGULO");

            else
            {
                if (Math.Pow(A, 2) == Math.Pow(B, 2) + Math.Pow(C, 2))
                    Console.WriteLine("TRIANGULO RETANGULO");

                if (Math.Pow(A, 2) > Math.Pow(B, 2) + Math.Pow(C, 2))
                    Console.WriteLine("TRIANGULO OBTUSANGULO");

                if (Math.Pow(A, 2) < Math.Pow(B, 2) + Math.Pow(C, 2))
                    Console.WriteLine("TRIANGULO ACUTANGULO");

                if (A == B && B == C)
                    Console.WriteLine("TRIANGULO EQUILATERO");

                if ((A == B && B != C) || (B == C && C != A) || (C == A && A != B))
                    Console.WriteLine("TRIANGULO ISOSCELES");
            }
		}    
	}
}