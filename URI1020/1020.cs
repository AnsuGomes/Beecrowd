using System;
class URI {
  static void Main() {

    int idade = int.Parse(Console.ReadLine());

    int ano = idade / 365;
    int resto = idade % 365;

    int mes = resto / 30;
    resto = resto % 30;

    int dia = resto / 1;
      
    Console.WriteLine($"{ano} ano(s)\n{mes} mes(es)\n{dia} dia(s)");  
  }
}