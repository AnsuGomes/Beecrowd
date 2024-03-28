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

            string[] coordenadas = Console.ReadLine().Split();
            double eixoX = double.Parse(coordenadas[0]);
            double eixoY = double.Parse(coordenadas[1]);

            if(eixoX == 0.0 && eixoY == 0.0)
                Console.WriteLine("Origem");

            else if(eixoX == 0)
                Console.WriteLine("Eixo Y");

            else if(eixoY == 0)
                Console.WriteLine("Eixo X");    

            else if(eixoX > 0.0 && eixoY > 0.0)    
                Console.WriteLine("Q1");

            else if(eixoX > 0.0 && eixoY < 0.0)    
                Console.WriteLine("Q4"); 

            else if(eixoX < 0.0 && eixoY > 0.0)    
                Console.WriteLine("Q2"); 
            
            else if(eixoX < 0.0 && eixoY < 0.0)    
                Console.WriteLine("Q3");
        }    
    }
}