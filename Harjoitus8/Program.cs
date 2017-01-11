/*
 * Tekijä: Juuso Huppunen
 * AsioID: K8960
 * Kurssi: TTOS0200
 * Harjoitus: Tehtävä 8
 * Kuvaus:
 *		Tee ohjelma, joka kysyy käyttäjältä 3 kokonaislukua
 *		ja tulostaa niistä suurimman.
 *		
 *		Esim:
 *		Anna Luku > 5 [Enter]
 *		Anna Luku > 15 [Enter]
 *		Anna Luku > 7 [Enter]
 *		
 *		Suurin luku on 15
 * Pvm: 12.1.2016 
 */

using System;

namespace Harjoitus8 {
	class Program {
		static void Main(string[] args)
		{
			// Kysytään numerot
			int[] Number = new int[3];
			for (int i = 0; i < 3; i++) {
				Console.Write("Please enter a number >");
				Number[i] = int.Parse(Console.ReadLine());
			}
			// Asetetaan taulukkoon saadut arvot pienimmästä suurimpaan
			Array.Sort(Number);

			// Tulostetaan taulukon viimeinen eli suurin arvo
			Console.WriteLine("The highest number is {0}", Number[2]);
		}
	}
}
