using System;

namespace URI
{
	class Program
	{
		static void Main()
		{
			string[] input = Console.ReadLine().Split();
			
			int horaInicial = int.Parse(input[0]);
			int minutoInicial = int.Parse(input[1]);
			int horaFinal = int.Parse(input[2]);
			int minutoFinal = int.Parse(input[3]);

			int horaTotal, minutoTotal;

			// Calcula a diferença de tempo
			TimeSpan inicio = new TimeSpan(horaInicial, minutoInicial, 0);
			TimeSpan fim = new TimeSpan(horaFinal, minutoFinal, 0);
			TimeSpan duracao = fim - inicio;

			// Se a diferença de tempo for negativa, adiciona 24 horas
			if (duracao < TimeSpan.Zero)
				duracao = duracao.Add(new TimeSpan(24, 0, 0));

			// Separa a duração em horas e minutos
			horaTotal = duracao.Hours;
			minutoTotal = duracao.Minutes;
			
			if (horaTotal == 0 && minutoTotal == 0)
                horaTotal = 24; // Se o jogo durou 0 horas e 0 minutos, é considerado como 24 horas

			Console.WriteLine($"O JOGO DUROU {horaTotal} HORA(S) E {minutoTotal} MINUTO(S)");
		}    
	}
}