using System;

namespace URICodes{

    class URI{
        static void Main (){

            string nomeVendedor = Console.ReadLine();

            double salario = Convert.ToDouble(Console.ReadLine());

            double totalVendas = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("TOTAL = R$ " + (salario + (totalVendas * 0.15)).ToString("F2"));
        }
    }
}