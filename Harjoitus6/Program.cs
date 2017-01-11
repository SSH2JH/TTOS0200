/*
 * Tekijä: Juuso Huppunen
 * AsioID: K8960
 * Kurssi: TTOS0200
 * Harjoitus: Tehtävä 5
 * Kuvaus:
 *		Auton kulutus on 7.02 litraa 100 kilometrin matkalla ja bensan hinta on 1.595 Euroa.
 *		Tee ohjelma, joka tulostaa ajetulla matkalla (kysytään käyttäjältä) kuluvan bensan määrän
 *		sekä bensaan menevän rahan määrän.
 *		
 *		Esimerkkitoiminta:
 *			Anna matka > 250 [Enter]
 *			Bensaa kuluu 17,55 litraa, kustannus 27,99 euroa
 * Pvm: 11.1.2016 
 */

using System;

namespace Harjoitus6 {
	class Program {
		static void Main(string[] args)
		{
			// Kysyy matkan käyttäjältä
			Console.Write("Please enter the distance (km) >");
			int Distance = int.Parse(Console.ReadLine());

			// Laskee kulutuksen valmiiksi
			double FuelLoss;
			FuelLoss = Distance * 0.0702;			

			// Tulostaa vaaditut arvot kahden desimaalin tarkkuudella
			Console.WriteLine("You consumed {0:0.00} litres of fuel and it was worth {1:0.00} euroa", FuelLoss, (FuelLoss * 1.595));
		}
	}
}
