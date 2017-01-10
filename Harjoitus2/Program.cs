/*
 * Tekijä: Juuso Huppunen
 * AsioID: K8960
 * Kurssi: TTOS0200
 * Harjoitus: Tehtävä 2
 * Kuvaus:
 *		Tee ohjelma, jossa annetaan oppilaalle koulunumero seuraavan
 *		taulukon mukaan (pistemäärä kysytään ja ohjelma tulostaa numeron):
 *		0-1 => 0
 *		2-3 => 1
 *		4-5 => 2
 *		6-7 => 3
 *		8-9 => 4
 *		10-12 => 5
 * Pvm: 10.1.2016 
 */

using System;

namespace Harjoitus2
{
	class Program
	{
		static void Main(string[] args)
		{
			// Kysytään pistemäärä
			Console.Write("Enter point qount >");
			int a = int.Parse(Console.ReadLine());

			/* 
			 * Testataan if ja if else valinnalla oikea koulunumero
			 * Ja tulostetaan se
			*/
			if (a <= 1 && a >= 0) {
				Console.WriteLine("School number is 0");
			} else if (a > 1 && a <= 3) {
				Console.WriteLine("School number is 1");
			} else if (a > 3 && a <= 5) {
				Console.WriteLine("School number is 2");
			} else if (a > 5 && a <= 7) {
				Console.WriteLine("School number is 3");
			} else if (a > 7 && a <= 9) {
				Console.WriteLine("School number is 4");
			} else if (a > 9 && a <= 12) {
				Console.WriteLine("School number is 5");
			}
		}
	}
}
