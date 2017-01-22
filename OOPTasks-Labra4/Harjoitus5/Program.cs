/*
 * Tekijä: Juuso Huppunen
 * AsioID: K8960
 * Kurssi: TTOS0200
 * Harjoitus: OOP Labra 4 - Tehtävä 5
 * Kuvaus:
 *		Tehtävässä tulee toteuttaa C#-ohjelma radion perustoimintojen testaamiseen.
 *		
 *		Kannettavassa radiossa on vain kolme säädintä: päälle/pois-kytkin,
 *		äänen voimakkuuden säädin (arvot 0, 1, 2,..., 9) ja kuunneltavan kanavan taajuusvalinta (2000.0 - 26000.0).
 *		
 *		Laadi luokka kannettavan radion toteutukseksi. Käytä tekemääsi luokkaa pääohjelmasta käsin,
 *		eli testaile radion toimivuutta erilaisilla voimakkuuden ja taajuuden arvoilla.
 *		Jätä asetus- ja tulostuslauseet näkyville pääohjelmaan, jotta radio-olion käyttö voidaan todentaa.
 * Pvm: 22.1.2017
 */

using System;

namespace OOP.Tasks {
	class Program {
		static void Main(string[] args)
		{
			HandRadio();
		}
		static void HandRadio()
		{
			Radio radio = new Radio();
			radio.IsOn = true;
			radio.Volume = 20;
			radio.Frequency = 12000.3;
			Console.WriteLine(radio.ToString());

			Console.WriteLine("-------------------------------");

			radio.IsOn = false;
			radio.Volume = 20;
			radio.Frequency = 19000.20;
			Console.WriteLine(radio.ToString());

			Console.WriteLine("-------------------------------");

			radio.IsOn = true;
			radio.Volume = 5;
			radio.Frequency = 50000.1;
			Console.WriteLine(radio.ToString());
		}
	}
}
