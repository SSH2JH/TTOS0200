/*
 * Tekijä: Juuso Huppunen
 * AsioID: K8960
 * Kurssi: TTOS0200
 * Harjoitus: Tehtävä 13
 * Kuvaus:
 *		Mäkihypyssä käytetään viittä arvostelutuomaria. Kirjoita ohjelma,
 *		joka kysyy arvostelupisteet yhdelle hypylle ja tulostaa tyylipisteiden summan siten,
 *		että summasta on vähennetty pois pienin ja suurin tyylipiste.
 *		Esim:
 *		
 *		Anna pisteet > 18 [Enter]
 *		Anna pisteet > 15 [Enter]
 *		Anna pisteet > 20 [Enter]
 *		Anna pisteet > 19 [Enter]
 *		Anna pisteet > 17 [Enter]
 *		Kokonaispisteet ovat 54
 * Pvm: 12.1.2016 
 */

using System;
using System.Linq;

namespace Harjoitus13
{
	class Program
	{
		static void Main(string[] args)
		{
			// Luodaan viiteen rajoitettu taulukko
			int[] JudgedPoints = new int[5];

			// Täytetään taulukko tuomarien arvoilla
			for(int i = 0; i < 5; i++) {
				Console.Write("Judge {0}, please enter your points >", (i + 1));
				JudgedPoints[i] = int.Parse(Console.ReadLine());
			}

			// Tulostetaan summa
			Console.WriteLine("Result is: {0}", JudgedPoints.Sum());
		}
	}
}
