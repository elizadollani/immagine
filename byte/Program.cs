using System;

namespace CalcoloDimensioniImmagine
{
    class Program
{
	static void Main(string[] args)
	{
		 string risultato;
		double calcolo = 0;
		Console.WriteLine("Inserisci il primo numero");
		 double n1 = Convert.ToDouble(Console.ReadLine());
		Console.WriteLine("Inserisci il secondo numero");
		double n2 = Convert.ToDouble(Console.ReadLine());
		Console.WriteLine("Inserisci la grandezza 1, 8, 16, 24");
		risultato = Console.ReadLine();
			switch (risultato)
			{
				case "1":
					calcolo = ((n1 * n2) / 8) / 1024;
					Console.WriteLine($"L'Immagine pesa {calcolo}KB");
					break;

				case "8":
					calcolo = (n1 * n2) / 1024;
					Console.WriteLine($"L'Immagine pesa {calcolo}KB");
					break;

				case "16":
					calcolo = ((n1 * n2) * 2) / 1024;
					Console.WriteLine($"L'Immagine pesa {calcolo}KB");
					break;

				case "24":
					calcolo = ((n1 * n2) * 3) / 1024;
					Console.WriteLine($"L'Immagine pesa {calcolo}KB");
					break;

				default:
					Console.WriteLine(" Attenzione questo codice vale per 1, 8 16, 24, inserire un numero corretto");
					break;
			}
			Console.ReadLine();






			}
}
}
