using System;

namespace URI
{
    class URI
    {
        static void Main()
        {   
            int X = int.Parse(Console.ReadLine());
            double Y = double.Parse(Console.ReadLine());

            Console.WriteLine($"{X / Y:F3} km/l");
        }
    }
}