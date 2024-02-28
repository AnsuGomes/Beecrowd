using System;

namespace URI
{
    class URI
    {
        static void Main()
        {
            int raio = int.Parse(Console.ReadLine());

            const double pi = 3.14159;

            Console.WriteLine($"VOLUME = {Math.Pow(raio, 3)* pi * (4.0 / 3):F3}");
        }
    }
}