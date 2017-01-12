/*
 * Tekijä: Juuso Huppunen
 * AsioID: K8960
 * Kurssi: TTOS0200
 * Harjoitus: Tehtävä 11
 * Kuvaus:
 *		Tee kahden sisäkkäisen for-silmukan avulla ohjelma,
 *		joka tulostaa seuraavanlaisen kuvion:
 *		*
 *		**
 *		***
 *		****
 *		*****
 *		
 *		Käyttäjä antaa syötteenä tähtirivien lukumäärän.
 *		Yllä olevassa esimerkissä käyttäjä on syöttänyt luvun 5.
 * Pvm: 12.1.2017
 */

using System;

namespace Harjoitus11
{
	class Program
	{
		static void Main(string[] args)
		{
			// Kysyy käyttäjältä luku
			int Rounds;
			Console.Write("Please enter a number >");
			Rounds = int.Parse(Console.ReadLine());

			// Pyöräyttää nested loop tekniikalla käyttäjän antaman luvun perusteella
			for(int i = 0; i < (Rounds); i++) {
				for(int j = 0; j < (i+1); j++) {
					Console.Write("*"); // Tämä pyörähtää ylemmän silmukan kierrosten verran
				}
				Console.WriteLine();
			}
		}
	}
}
