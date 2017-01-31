/*
 * Tekijä: Juuso Huppunen
 * AsioID: K8960
 * Kurssi: TTOS0200
 * Harjoitus: OOP Labra 7 - Tehtävä 1
 * Kuvaus:
 *		 Tee ohjelma, joka kirjoittaa käyttäjän antamat merkkijonot tiedostoon
 *		 (lopetusehdon voit päättää itse) ja sulje tiedosto.
 *		 Avaa tämän jälkeen tiedosto lukemista varten ja tulosta näyttölaitteelle tiedoston sisältö riveittäin.
 *		 Huomioi mahdolliset poikkeukset, joita tiedoston käsittely voi aiheuttaa.
 * Pvm: 31.1.2017
 */

using System;
using System.IO;

namespace OOP.Tasks {
	class Program {
		static void Main(string[] args)
		{
			InputQuery();
		}
		static void InputQuery()
		{
			string input;

			// Creates outputFile object
			System.IO.StreamWriter outputFile = null;
			try {
				// Initializes outputFile object
				outputFile = new System.IO.StreamWriter(@"test.txt");
				while (true) {
					Console.Write("Give a text line (enter ends) >");
					input = Console.ReadLine();
					// ends the loop
					if (input == "")
						break;
					// Saves the information
					outputFile.WriteLine(input);
				}
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
				if (outputFile != null) {
					outputFile.Close();
				}
			}
		}
	}
}
