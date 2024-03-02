using System;

namespace URI
{
    class URI
    {
        static void Main()
        {
            string[] valores  = Console.ReadLine().Split();
    
            int A = int.Parse(valores[0]);
            int B = int.Parse(valores[1]);
            int C = int.Parse(valores[2]);  
                
            int valorMaior = A;

            if(A < B || A < C){
                if(B < C)
                valorMaior = C;
                else
                valorMaior = B;  
            }
            else
                valorMaior = A;

            Console.WriteLine($"{valorMaior} eh o maior");
        }
    }
}