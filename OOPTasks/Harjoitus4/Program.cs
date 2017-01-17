/*
 * Tekijä: Juuso Huppunen
 * AsioID: K8960
 * Kurssi: TTOS0200
 * Harjoitus: OOP - Tehtävä 4
 * Kuvaus:
 *		Luo Vehicle-luokka annettujen tietojen mukaisesti.
 *		Toteuta Vehicle-luokan ohjelmointi sekä pääohjelma,
 *		jolla luot olion Vehicle-luokasta. Muuta olion arvoja ja tulosta olion arvoja konsolille. 
 * Pvm: 17.1.2017
 */

using System;

namespace OOP.Tasks {
	class Program {
		static void Main(string[] args)
		{
			// Siirrytään ajoneuvoluokkaa käsittelevään metodiin
			VehicleFunc();
		}

		static void VehicleFunc()
		{
			// luodaan olio auto ja annetaan sen parametreille arvot
			Vehicle vehicle = new Vehicle();
			vehicle.Name = "Car";
			vehicle.Speed = 140;
			vehicle.Tyres = 4;
			// Tulostetaan annetut arvot
			vehicle.PrintData();

			// Otetaan annetut arvot vastaan yhtenä merkkijonona
			Console.WriteLine(vehicle.ToString(vehicle));

			Console.Write("\n\n\n---------------------------------------------\n");

			// Luodaan olio pyörä ja annetaan arvot, muuten sama kuin auto
			Vehicle vehicle2 = new Vehicle();
			vehicle2.Name = "Bike";
			vehicle2.Speed = 50;
			vehicle2.Tyres = 2;
			// Tulostus
			vehicle2.PrintData();
			// Tietojen vastaanotto merkkijonona
			Console.WriteLine(vehicle.ToString(vehicle2));

			Console.Write("\n\n\n---------------------------------------------\n");
		}
	}
}
