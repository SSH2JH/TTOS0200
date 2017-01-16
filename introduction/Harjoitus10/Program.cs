/*
 * Tekijä: Juuso Huppunen
 * AsioID: K8960
 * Kurssi: TTOS0200
 * Harjoitus: Tehtävä 10
 * Kuvaus:
 *		Tee ohjelma, joka alustaa sovellukseen käyttöö seuraavan
 *		taulukon arvot = [1,2,33,44,55,68,77,96,100].
 *		Käy sovelluksessa taulukko läpi ja tulosta ruutuun "HEP"-sana
 *		aina kun taulukossa oleva luku on parillinen.
 * Pvm: 12.1.2017
 */

using System;

namespace Harjoitus10
{
	class Program
	{
		static void Main(string[] args)
		{
			// Asetetaan taulukko
			int[] numbers = new int[9] { 1, 2, 33, 44, 55, 68, 77, 96, 100 };
			// Käydään taulukko läpi
			for (int i = 0; i < 9; i++) {
				if((numbers[i] % 2) == 0) {
					// Nyt taulukon arvo on jaollinen kahdella
					Console.WriteLine("HEP");
				} else {
					// Täällä ei ole
					Console.WriteLine(numbers[i]);
				}
			}
		}
	}
}
