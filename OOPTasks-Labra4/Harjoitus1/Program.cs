/*
 * Tekijä: Juuso Huppunen
 * AsioID: K8960
 * Kurssi: TTOS0200
 * Harjoitus: OOP Labra 4 - Tehtävä 1
 * Kuvaus:
 *		Tehtävänäsi on ohjelmoida Dynamon hissin kerroksen ohjaukseen liittyvä säädin.
 *		Toteutetun ohjelman tulee pystyä kysymään käyttäjältä haluttu kerros ja 
 *		siirtämään hissi haluttuun kerrokseen (tässä tapauksessa ohjelma kertoo
 *		käyttäjälle missä kerroksessa hissi on). Muista, että Dynamon hissi voi olla vain kerroksissa 1-5.
 *		Käytä Hissi-luokassa get- ja set-aksessoreita suojamaan olion tila.
 * Pvm: 17.1.2017
 */

using System;

namespace OOP.Tasks {
	public class Program {
		static void Main(string[] args)
		{
			ElevatorFunc();
		}

		static void ElevatorFunc()
		{
			// Asetetaan muuttujat
			Elevator elevator = new Elevator();
			// Tulostetaan nykyinen kerros
			Console.WriteLine("Your current floor is {0}", elevator.CurrentFloor);

			// Ohjelman päälooppi
			while (true) {
				// Kysytään käyttäjältä arvot
				Console.Write("Please, give a new floor number (-1 to exit) >");
				string input = Console.ReadLine();
				if (input != "-1") {
					Console.WriteLine(elevator.ChangeFloor(input));
				}
				else {
					// Ohjelman suoritus päättyy
					Console.WriteLine("Exiting...");
					break;
				}
			}
		}
	}
}
