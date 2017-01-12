/*
 * Tekijä: Juuso Huppunen
 * AsioID: K8960
 * Kurssi: TTOS0200
 * Harjoitus: Tehtävä 9
 * Kuvaus:
 *		Tee ohjelma, joka kysyy käyttäjältä lukuja, kunnes hän syöttää luvun 0.
 *		Ohjelman tulee tulostaa syötettyjen lukujen summa.
 *		
 *		Esim:
 *		Anna Luku > 10 [Enter]
 *		Anna Luku > 20 [Enter]
 *		Anna Luku > 30 [Enter]
 *		Anna Luku > 0 [Enter]
 *		
 *		Lukujen summa on 60
 * Pvm: 12.1.2017
 */

using System;

namespace Harjoitus9 {
	class Program {
		static void Main(string[] args)
		{
			// Käyttäjältä kysytään ensimmäinen arvo
			int Input, Sum = 0;
			Console.Write("Please enter a number >");
			Input = int.Parse(Console.ReadLine());
			// Mikäli ensimmäinen arvo ei ole nolla siirrytään silmukkaan
			while (Input != 0) {
				Sum += Input; // Tässä käyttäjän antama arvo lisätään lopulliseen arvoon

				// Tässä arvo kysytään uudestaan
				Console.Write("Please enter a number >");
				Input = int.Parse(Console.ReadLine());
			}
			// Lopullisen arvon tulostus
			Console.WriteLine("The sum of given numbers is: {0}", Sum);
		}
	}
}
