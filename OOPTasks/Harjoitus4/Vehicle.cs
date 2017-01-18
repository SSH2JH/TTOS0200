using System;

namespace OOP.Tasks {
	public class Vehicle {
		// Parametrit nimi,
		public string Name { get; set; }
		// Nopeus
		public int Speed { get; set; }
		// Renkaiden määrä
		public int Tyres { get; set; }

		// Printteri metodi.
		public void PrintData()
		{
			Console.WriteLine("The vehicle is {0}", Name);
			Console.WriteLine("It can go {0} km/h", Speed);
			Console.WriteLine("It's {0} tyred vehicle.", Tyres);
		}
		// Tulostaa olion arvot yhtenä mekkijonona ja palauttaa ne
		public override string ToString()
		{
			// x edustaa tuntematonta oliota joka syötetään pääohjelmasta
			return String.Format("{0}, {1}, {2}", Name, Speed, Tyres);
		}
	}
}
