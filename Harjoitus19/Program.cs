/*
 * Tekijä: Juuso Huppunen
 * AsioID: K8960
 * Kurssi: TTOS0200
 * Harjoitus: Tehtävä 19
 * Kuvaus:
 *		Tee tekstipohjainen Hirsipuu-peli. Voit kovakoodata arvattavan sanan ja toteuta looppi,
 *		jossa käyttäjältä kysytään seuraavaa kirjainta. Muista näyttää aina kirjaimen jälkeen oikein
 *		arvatut kirjaimet sanan oikealla kohdalla (käytä esim _-alaviivaa ei arvattujen kirjainten kohdalla).
 *		Voit näyttää myös jo arvatut ei käytetyt -kirjaimet. Päätä itse milloin pelaaja joutuu hirteen. 
 * Pvm: 15.1.2017
 */

using System;
/*using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;*/

namespace Harjoitus19 {
	class Program {
		static void Main(string[] args)
		{
			string puzzleWord = "jamk";
			int a = puzzleWord.Length;
			for (int i = 0; i < a; i++) {
				Console.Write("_ ");
			}
		}
	}
}
