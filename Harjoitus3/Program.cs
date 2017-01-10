/*
 * Tekijä: Juuso Huppunen
 * AsioID: K8960
 * Kurssi: TTOS0200
 * Harjoitus: Tehtävä 3
 * Kuvaus:
 *		Tee ohjelma, joka kysyy käyttäjältä kolme lukua ja
 *		tulostaa niiden summan ja keskiarvon.
 * Pvm: 10.1.2016 
 */

using System;

namespace Harjoitus3 {
	class Program {
		static void Main(string[] args)
		{
			/*
			 * Luodaan taulukko kysyttäville luvuille
			 * ja kysytään käyttäjältä 3 arvoa
			 */
			int[] Numbers = new int[3];
			Console.WriteLine("Please enter three numbers");
			for (int i = 0; i < 3; i++) {
				Console.Write(">");
				Numbers[i] = int.Parse(Console.ReadLine());
			}

			// Sum
			int Sum = Numbers[0] + Numbers[1] + Numbers[2];
			// Average
			int Average = Sum / 3;

			// Tulostaa lasketut arvot käyttäjälle
			Console.WriteLine("-------------------------------------------------");
			Console.WriteLine("The sum of these numbers is: {0}. Average is: {1}", Sum, Average);
		}
	}
}
