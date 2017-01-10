/*
 * Tekijä: Juuso Huppunen
 * AsioID: K8960
 * Kurssi: TTOS0200
 * Harjoitus: Tehtävä 1
 * Kuvaus:
 *		Tee ohjelma, joka tulostaa käyttäjän antamaa lukua (1, 2 tai 3)
 *		vastaavan luvun sanana (yksi, kaksi tai kolme).
 *		Jos käyttäjä syöttää jonkin muun luvun, tulee näytölle
 *		tulostaa teksti: "joku muu luku". 
 * Pvm: 10.1.2016 
 */

using System;

namespace Harjoitus1
{
	class Program
	{
		static void Main(string[] args)
		{
			// Kysytään käyttäjältä arvo
			Console.Write("Please enter a number >");
			int a = int.Parse(Console.ReadLine());

			// Testataan arvo switch case:illä
			switch (a) {
				case 1: // käyttäjä syötti a = 1
					Console.WriteLine("You entered number one!");
					break;
				case 2: // käyttäjä syötti a = 2
					Console.WriteLine("You entered number two!");
					break;
				case 3: // käyttäjä syötti a = 3
					Console.WriteLine("You entered number three!");
					break;
				default: // käyttäjä syötti jotakin muuta
					Console.WriteLine("You entered some other number!");
					break;
			}
		}
	}
}
