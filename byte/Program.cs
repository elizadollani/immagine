using System;

namespace CalcoloDimensioniImmagine
{
    class Program
{
	static void Main(string[] args)
	{
		int n1, n2;
		Console.WriteLine("Inserisci il prim o numero");
		n1 = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Inserisci il secondo numero");
		n2 = Convert.ToInt32(Console.ReadLine());
		int calcolo = ((n1*n2)*3)/1024;
		Console.WriteLine($"L' immagine pesa {calcolo}KB");
			Console.ReadLine();




		}
}
}
