/*
 * Tekijä: Juuso Huppunen
 * AsioID: K8960
 * Kurssi: TTOS0200
 * Harjoitus: OOP Labra 4 - Tehtävä 2
 * Kuvaus:
 *		Tehtävänäsi on ohjelmoida yksinkertaisen vahvistimen toiminta,
 *		jolla voidaan kontrolloida äänenvoimakkuutta välillä 0-100.
 *		Toteuta Vahvistin-luokka ja tee pääohjelma, jolla luot olion Vahvistin-luokasta.
 *		Säädä ja kokeile vahvistinta eri äänenvoimakkuuksilla.
 *		Käytä Vahvistin-luokassa get- ja set-aksessoreita.
 *		get-aksessori palauttaa äänenvoimakkuuden ja set-aksessori rajaa äänenvoimakkuuden arvoa.
 * Pvm: 18.1.2017
 */

using System;

namespace OOP.Tasks {
	class Program {
		static void Main(string[] args)
		{
			AmplifierFunc();
		}

		static void AmplifierFunc()
		{
			Amplifier amp = new Amplifier("Yamaha", 0);

			Console.WriteLine(amp.PrintStatus());

			amp.AmpVolume = 50;
			Console.WriteLine(amp.PrintStatus());

			amp.AmpVolume = 150;
			Console.WriteLine(amp.PrintStatus());

			amp.AmpVolume = -60;
			Console.WriteLine(amp.PrintStatus());
		}
	}
}
