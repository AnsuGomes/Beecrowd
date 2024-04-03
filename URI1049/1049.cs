using System;
using System.Globalization;
class URI
{
  static void Main()
  {
    CultureInfo culture = new CultureInfo("en-US");
    NumberFormatInfo numberFormat = culture.NumberFormat;
    CultureInfo.CurrentCulture = culture;

    string namePrimeiro = Console.ReadLine();
    string nameSegundo = Console.ReadLine();
    string nameTerceiro = Console.ReadLine();

    if(namePrimeiro == "vertebrado"){
      if(nameSegundo == "ave"){
        if(nameTerceiro == "carnivoro")
          Console.WriteLine("aguia");
        else
          Console.WriteLine("pomba");
      }
      else if(nameSegundo == "mamifero"){
        if(nameTerceiro == "onivoro")
          Console.WriteLine("homem");
        else
          Console.WriteLine("vaca");
      }
    }
    else if (namePrimeiro == "invertebrado"){
      if(nameSegundo == "inseto"){
        if(nameTerceiro == "hematofago")
          Console.WriteLine("pulga");
        else
          Console.WriteLine("lagarta");
      }
      else if(nameSegundo == "anelideo"){
        if(nameTerceiro == "hematofago")
          Console.WriteLine("sanguessuga");
        else
          Console.WriteLine("minhoca");
      }
    }
  }
}