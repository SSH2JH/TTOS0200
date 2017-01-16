/*
 * Tekijä: Juuso Huppunen
 * AsioID: K8960
 * Kurssi: TTOS0200
 * Harjoitus: Tehtävä 14
 * Kuvaus:
 *		Kirjoita ohjelma, joka pyytää käyttäjältä opiskelijoiden
 *		arvosanat 0-5 ohjelmointi-opintojaksosta (voit itse päättää lopetusehdon).
 *		Tulosta arvosanajakauma käyttäen tähtimerkkejä seuraavasti:
 *		
 *		Arvosanajakauma:
 *		0:
 *		1:****
 *		2:**
 *		3:******
 *		4:*****
 *		5:** 
 * Pvm: 12.1.2017
 */

using System;

namespace Harjoitus14
{
	class Program
	{
		static void Main(string[] args)
		{
			// Luodaan tarvittavat muuttujat
			int[] grades = new int[5];
			string input;
			int inputNumeric;
			bool isNumeric, isStarted = false;

			// Tulostetaan tyhjä tuloskenttä ja käyttöohjeet
			DistributionPrinter(grades, isStarted);
			PrintHelp();

			// Ohjelman pääsilmukka
			while (true) {
				// Otetaan käyttäjän syöte vastaan merkkijonona
				Console.Write("Please enter the grade (-2 for help page) >");
				input = Console.ReadLine();

				// Testataan oliko käyttäjän syöte kokonaisluku
				isNumeric = int.TryParse(input, out inputNumeric);

				// Ainoastaan kokonaisluvut väliltä [-2, 5] hyväksytään. Kaikki muut arvot hylätään
				if(isNumeric == true && inputNumeric <=5 && inputNumeric >= -2) {
					switch (inputNumeric) {
						case -1:
							// Ohjelman lopetuskäsky
							Console.WriteLine("\nExiting...");
							return;
						case -2:
							// Käyttöohjeet
							PrintHelp();
							break;
						default:
							/* 
							 * Ohjelman päätarkoitus. Numero osoitetaan taulukon sitä vastaavaan lohkoon
							 * ja sen lohkon arvoa lisätään yhdellä
							 * Samalla määritetään ohjelman suoritus alkaneeksi
							 */
							grades[inputNumeric - 1]++;
							isStarted = true;
							// Täällä tulostetaan arvosanajakauma muutoksen jälkeen (eli kun IsStarted = true)
							DistributionPrinter(grades, isStarted);
							break;
					}
				} else {
					// Yleinen virheviesti
					Console.WriteLine("Invalid input!");
				}
			}
		}
		// Taulukon printtaus aliohjelma
		static void DistributionPrinter(int[] Grades, bool IsStarted)
		{
			/*
			 * Tulostetaan jakauma nested loopin avulla
			 * Päälooppi tulostaa arvosanan arvon ja sisempi tulostaa
			 * näille arvoille jakauman osumat
			 */
			Console.WriteLine("\n\nGrade distribution:");
			for (int i = 0; i < 5; i++) {
				Console.Write("{0}: ", (i+1));
				/* 
				 * Täällä tulostetaan * -merkit osoittamaan saatujen arvosanojen määrää
				 * JOS ohjelmalle on syötetty ensimmäinen luku
				*/
				if(IsStarted == true) {
					for(int j = 0; j < Grades[i]; j++) {
						Console.Write("*");
					}
				}
				Console.WriteLine();
			}
		}
		// Aliohjelma printtaa ohjelman käyttöohjeet
		static void PrintHelp()
		{
			Console.WriteLine("\nGuide for using this program:\n"
				+ "\t-1 to exit.\n"
				+ "\t-2 for this help page.\n"
				+ "\t> Otherwise simply enter the grades\n");
		}
	}
}