/*
 * Tekijä: Juuso Huppunen
 * AsioID: K8960
 * Kurssi: TTOS0200
 * Harjoitus: Tehtävä 17
 * Kuvaus:
 *		Tee ohjelma, joka lajittelee kahdessa kokonaislukutaulukossa
 *		olevat alkiot suurusjärjestykseen kolmanteen kokonaislukutaulukkoon.
 *		Tulosta lopuksi lajitellun taulukon sisältö.
 *		Esim:
 *		
 *		Luvut taulukossa 1 : 10,20,30,40,50
 *		Luvut taulukossa 2 : 5,15,25,35,45
 *		Luvut yhdistetyssä taulukossa : 5,10,15,20,25,30,35,40,45,50
 * Pvm: 15.1.2017
 */

using System;

namespace Harjoitus17 {
	class Program {
		static void Main(string[] args)
		{
			// Luodaan taulukot
			int[] array1 = { 10, 20, 30, 40, 50};
			int[] array2 = { 5, 15, 25, 35, 45 };
			int[] array3 = new int[10];

			// Tämä laskee taulukon arvoja eteenpäin
			int count = 0;

			// Siirtää taulukon arvot kolmanteen taulukkoon
			for (int i = 0; i < (array1.Length); i++) {
				array3[count] = array1[i];
				count++;
			}
			for (int i = 0; i < array2.Length; i++) {
				array3[count] = array2[i];
				count++;
			}

			// Järjestää array3-taulukon sisällön
			Array.Sort(array3);

			// Tulostaa lopputuloksen
			for (int i = 0; i < (array3.Length); i++) {
				Console.WriteLine(array3[i]);
			}
		}
	}
}
