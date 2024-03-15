using System;
using System.Globalization;
class URI {
  static void Main() {

    CultureInfo culture = new CultureInfo("en-US");
    NumberFormatInfo numberFormat = culture.NumberFormat;
    CultureInfo.CurrentCulture = culture;

    string[] valores = Console.ReadLine().Split();
    double a = double.Parse(valores[0]);
    double b = double.Parse(valores[1]);
    double c = double.Parse(valores[2]);

    if(a == 0){
      Console.WriteLine("Impossivel calcular");
      return;
    }

    var delta = Math.Pow(b, 2) - (4 * a * c);

    if(delta < 0){
      Console.WriteLine("Impossivel calcular"); 
      return;
    }

    var x = (- b + Math.Sqrt(delta)) / (2 * a) ;
    var y = (- b - Math.Sqrt(delta)) / (2 * a) ;

    Console.WriteLine($"R1 = {x:F5}\nR2 = {y:F5}");
  }
}