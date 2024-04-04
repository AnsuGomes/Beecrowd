using System.Collections.Generic;
using System.Globalization;
using System;

class URI
{
  static void Main()
  {
    CultureInfo culture = new CultureInfo("en-US");
    NumberFormatInfo numberFormat = culture.NumberFormat;
    CultureInfo.CurrentCulture = culture;

    Dictionary<int, string> meses = new Dictionary<int, string>(){
      {1, "January"},
      {2, "February"},
      {3, "March"},
      {4, "April"},
      {5, "May"},
      {6, "June"},
      {7, "July"},
      {8, "August"},
      {9, "September"},
      {10, "October"},
      {11, "November"},
      {12, "December"}
    };

    int input = int.Parse(Console.ReadLine());

    if(meses.ContainsKey(input))
      Console.WriteLine($"{meses[input]}");
  }
}