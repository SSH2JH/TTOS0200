/*
 * Tekijä: Juuso Huppunen
 * AsioID: K8960
 * Kurssi: TTOS0200
 * Harjoitus: Tehtävä 12
 * Kuvaus:
 *		Tee ohjelma, joka kysyy käyttäjältä 5 kokonaislukua.
 *		Luvut tulee sijoittaa taulukkoon.
 *		Ohjelman tulee tulostaa annetut luvut käänteisessä järjestyksessä.
 *		
 *		Anna Luku > 1 [Enter]
 *		Anna Luku > 2 [Enter]
 *		Anna Luku > 3 [Enter]
 *		...
 *		...
 *		Luvut ovat: 3,2,1
 * Pvm: 12.1.2017
 */

using System;

namespace Harjoitus12
{
	class Program
	{
		static void Main(string[] args)
		{
			// Luodaan integer-taulukko ja lukitaan sen pituus viiteen
			int[] Numbers = new int[5];
			// Täytetään taulukko käyttäjän syötteellä
			for(int i = 0; i < 5; i++) {
				Console.Write("Please enter the {0}. number >", (i+1));
				Numbers[i] = int.Parse(Console.ReadLine());
			}
			// Tulostetaan käyttäjän antama syöte vastakkaisessa järjestyksessä
			Console.Write("Numbers are in reverse: ");
			for (int i = (Numbers.Length - 1); i >= 0; i--) {
				Console.Write("{0} ", Numbers[i]);
			}
			Console.WriteLine();
		}
	}
}
