/*
 * Tekijä: Juuso Huppunen
 * AsioID: K8960
 * Kurssi: TTOS0200
 * Harjoitus: Tehtävä 15 [NOT FINISHED]
 * Kuvaus:
 *		Tee ohjelma, joka arpoo satunnaisluvun väliltä 0-100. Käytä C#:n Random -luokkaa.
 *		Tämän jälkeen ohjelman käyttäjää kehoitetaan arvaaman arvottu luku.
 *		Ohjelman tulee antaa vihje arvauksen jälkeen onko arvottu luku pienempi vai suurempi.
 *		Tämän jälkeen vihjeitä toistetaan kunnes käyttäjä arvaa oikean luvun.
 *		Tulosta lopuksi arvausten määrä näytölle. PS Satunnaislukujen arpomisesta tietokoneella
 *		löytyy mielenkiintoista luettavaa esimerkiksi tästä artikkelista: Computers are lousy random number generators. 
 *		
 *		Arvaa luku > 50 [Enter]
 *		Luku on suurempi
 *		Arvaa luku > 75 [Enter]
 *		Luku on pienempi
 *		Arvaa luku > 66 [Enter]
 *		Hienoa, arvasit luvun 3 kerralla.
 * Pvm: 12.1.2017
 */

using System;

namespace Harjoitus16 {
	class Program {
		static void Main(string[] args)
		{
			// Luodaan tarvittavat muuttujat
			Random rnd = new Random();
			int a = rnd.Next(0, 100);
			string UserInput;
			int InputNumeric, Attempts = 1;
			bool IsNumeric;

			// Annetaan käyttöohjeet
			Console.WriteLine("Your job is to try and guess a number.\n"
				+ "If you input anything but a number program will exit!");

			// Ohjelman pääsuoritus silmukka
			while (true) {
				// Kysytään käyttäjältä arvaus ja varmistetaan että se on kokonaisluku
				Console.Write(">");
				UserInput = Console.ReadLine();
				IsNumeric = int.TryParse(UserInput, out InputNumeric);

				/* 
				 * Jos käyttäjä antoi numeron tarkistetaan onko se suurempi,
				 * pienempi tai yhtäsuuri arvotun numeron kanssa.
				 */
				if(IsNumeric == true) {
					if(a > InputNumeric) {
						// Käyttäjän arvo on liian pieni
						Console.WriteLine("The number is larger.");
					} else if (a < InputNumeric) {
						// Käyttäjän antama arvo on liian suuri
						Console.WriteLine("The number is smaller.");
					} else {
						// Käyttäjä voitti
						Console.WriteLine("You guessed the number in {0} attempts!", Attempts);
						return;
					}
					Attempts++; // Tässä lasketaan yritysten määrä
				} else {
					// Yleinen virheviesti ja keino poistua ohjelmasta
					Console.WriteLine("\nInvalid input!\nExiting...");
					break;
				}
			}
		}
	}
}
