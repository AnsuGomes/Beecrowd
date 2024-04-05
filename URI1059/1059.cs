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

    for(int i = 1; i <= 100; i++ ){
      if(i % 2 == 0)
        Console.WriteLine(i);
    }
  }
}
