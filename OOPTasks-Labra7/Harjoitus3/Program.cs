/*
 * Tekijä: Juuso Huppunen
 * AsioID: K8960
 * Kurssi: TTOS0200
 * Harjoitus: OOP Labra 7 - Tehtävä 3
 * Kuvaus:
 *		 Tee ohjelma, joka lukee yksinkertaisesta tekstitiedostosta nimet.txt henkilöitten nimiä
 *		 ja kertoo montako nimeä löytyy ja montako kertaa kukin nimi esiintyy.
 *		 Kopioi (tai luo itse vastaava tiedosto) D:\Temp -kansioon ja ohjelmoi koodisi tarkistamaan onko
 *		 em.hakemistossa tiedostoa.Käytä File.Exist-metodia.
 *		 Huomioi myös muut mahdolliset poikkeukset, joita tiedoston käsittely voi aiheuttaa. 
 * Pvm: 1.2.2017
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Tasks {
	class Program {
		static void Main(string[] args)
		{
			NameReader();
		}
		static void NameReader()
		{
			StreamWriter inputFile = null;
			try {
				// Initializes outputFile object
				inputFile = new StreamWriter(@"names.txt");
				
			}
			catch (UnauthorizedAccessException) {
				Console.WriteLine("Can't open file for writing (UnauthorizedAccessException)");
			}
			catch (ArgumentNullException) {
				Console.WriteLine("Opened stream is null (ArgumentNullException)");
			}
			catch (ArgumentException) {
				Console.WriteLine("Opened stream is not writable (ArgumentException)");
			}
			catch (IOException) {
				Console.WriteLine("An IO error happend (IOException)");
			}
			catch (Exception) {
				Console.WriteLine("Some other exception happend (Exception)");
			}
			finally {
				// check for null because OpenWrite might have failed
				if (inputFile != null) {
					inputFile.Close();
				}
			}
		}
	}
}
