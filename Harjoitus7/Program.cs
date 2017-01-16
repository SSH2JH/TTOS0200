/*
 * Tekijä: Juuso Huppunen
 * AsioID: K8960
 * Kurssi: TTOS0200
 * Harjoitus: Tehtävä 7
 * Kuvaus:
 *		Tee ohjelma, joka näyttää onko annettu vuosi karkausvuosi.
 *		Vuosiluku kysytään käyttäjältä.
 *		
 *		4:llä jaolliset on, paitsi täydet vuosisadat.
 *		Kuitenkin 400:lla jaolliset vuosisadat ovat
 *		
 *		Esim. 1991 -> ei, 1992 -> on, 1900 -> ei, 2000 -> on
 * Pvm: 11.1.2017
 */

using System;

namespace Harjoitus7 {
	class Program {
		static void Main(string[] args)
		{
			// Kysytään käyttäjältä vuosiluku
			int year;
			Console.Write("Please enter a year >");
			year = int.Parse(Console.ReadLine());

			/* 
			 * Verrataan saatua vuosilukua jakojäännöksen avulla
			 * siten että: kun vuosi on jaollinen neljällä mutta ei sadalla se on karkausvuosi
			 * Se on karkausvuosi myös kun se on jaollinen luvulla 400
			 */
			if ((year & 4) == 0 && (year % 100) != 0 || (year % 400) == 0) {
				// On karkausvuosi
				Console.WriteLine("{0} is a leap year!", year);
			} else {
				// Ei ole karkausvuosi
				Console.WriteLine("{0} is not a leap year!", year);
			}
		}
	}
}
