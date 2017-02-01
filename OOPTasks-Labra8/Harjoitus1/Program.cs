/*
 * Tekijä: Juuso Huppunen
 * AsioID: K8960
 * Kurssi: TTOS0200
 * Harjoitus: OOP Labra 8 - Tehtävä 1
 * Kuvaus:
 *		 Toteuta Noppa-luokka siten, että noppaa voidaan heittää.
 *		 Nopan tulee palauttaa satunnainen luku jokaisella heittokerralla.
 *		 Toteuta pääohjelmassa nopan heittäminen. Kokeile ensin heittää noppaa kerran ja tulosta nopan luku.
 *		 Toteuta tämän jälkeen ohjelma siten, että kysyt käyttäjältä heittojen määrän.
 *		 Heitä noppaa ja tulosta heittojen lukujen keskiarvo. 
 * Pvm: 1.2.2017
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Tasks {
	class Program {
		static void Main(string[] args)
		{
			DiceThrow();
		}
		static void DiceThrow()
		{
			Dice diceThrow = new Dice();
			List<int> throws = new List<int>();
			string input;
			bool isNumeric;
			int inputNumeric;
			int result;
			float summa = 0;
			float average;

			Console.Write("How many times you want to throw a dice >");
			input = Console.ReadLine();
			isNumeric = int.TryParse(input, out inputNumeric);

			if (isNumeric == true) {
				int i = 0;
				while (i < inputNumeric) {
					result = diceThrow.ThrowDice();
					summa += result;
					i++;
				}
				average = summa / inputNumeric;
				Console.WriteLine("Dice is now thrown {0} times, average is {1}", inputNumeric, average);
			} else {
				Console.WriteLine("You entered non integer!\n\nExiting...");
			}
		}
	}
}
