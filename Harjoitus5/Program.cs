/*
 * Tekijä: Juuso Huppunen
 * AsioID: K8960
 * Kurssi: TTOS0200
 * Harjoitus: Tehtävä 5
 * Kuvaus:
 *		Tee ohjelma, joka näyttää annetun sekuntimäärän tunteina,
 *		minuutteina ja sekunteina. Aikamääre sekuntteina kysytään käyttäjältä
 *		esim: 3661s -> Antamasi sekunttiaika voidaan ilmaista muodossa: 1 tunti 1 minuutti 1 sekuntti
 * Pvm: 11.1.2016 
 */


using System;

namespace Harjoitus5 {
	class Program {
		static void Main(string[] args)
		{
			// Kyselee käyttäjältä sekuntit
			Console.Write("Enter some seconds >");
			double seconds = double.Parse(Console.ReadLine());
			// Syöttää käyttäjän inputin double
			TimeSpan time = TimeSpan.FromSeconds(seconds);
			// Tulostaa halutussa formaatissa
			Console.WriteLine("{0:%h} hours {0:%m} minutes {0:%s} seconds", time);
		}
	}
}
