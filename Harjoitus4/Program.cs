/*
 * Tekijä: Juuso Huppunen
 * AsioID: K8960
 * Kurssi: TTOS0200
 * Harjoitus: Tehtävä 4
 * Kuvaus:
 *		Tee ohjelma, jossa kysytään käyttäjältä tämän ikä. Jos ikä on alle 18 vuotta,
 *		tulosta "alaikäinen", jos se on 18-65 vuotta, tulosta "aikuinen",
 *		muussa tapauksessa tulosta "seniori".
 * Pvm: 10.1.2016 
 */


using System;

namespace Harjoitus4 {
	class Program {
		static void Main(string[] args)
		{
			// Kysyy käyttäjän iän
			Console.Write("Please enter your age >");
			int age = int.Parse(Console.ReadLine());

			// Tulostaa vastauksen annetun iän perusteella
			Console.WriteLine("\n\n--------------------------------------");
			if(age < 18) { // Alle 18
				Console.WriteLine("You are underaged!");
			} else if (age >= 18 && age < 65) { // Vuosi 18 ja sen ja 65 välissä
				Console.WriteLine("You are an adult!");
			} else { // Käyttäjä on 65 tai vanhempi
				Console.WriteLine("You are senior citizen!");

			}
		}
	}
}
