using System.Globalization;

namespace URI
{
    class URI
    {
        static void Main()
        {
            /* Questão de ponto/virgula nos valores:
            
            CultureInfo culture = new CultureInfo("en-US");
            NumberFormatInfo numberFormat = culture.NumberFormat;
            CultureInfo.CurrentCulture = culture;
            */

            string[] primeirosValores = Console.ReadLine().Split();
            string[] segundosValores = Console.ReadLine().Split();

            int codigoPeca1 = int.Parse(primeirosValores[0]);
            int quantidadePeca1 = int.Parse(primeirosValores[1]);
            double valorPeca1 = double.Parse(primeirosValores[2]);

            int codigoPeca2 = int.Parse(segundosValores[0]);
            int quantidadePeca2 = int.Parse(segundosValores[1]);
            double valorPeca2 = double.Parse(segundosValores[2]);

            var valorTotal = (quantidadePeca1 * valorPeca1) + (quantidadePeca2 * valorPeca2);

            Console.WriteLine($"VALOR A PAGAR: R$ {valorTotal:F2}");
        }
    }
}
