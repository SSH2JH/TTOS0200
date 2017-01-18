/*
 * Tekijä: Juuso Huppunen
 * AsioID: K8960
 * Kurssi: TTOS0200
 * Harjoitus: OOP - Tehtävä 3
 * Kuvaus:
 *		Tehtävänäsi on ohjelmoida television toiminta. Samoin kuin edellinen tehtävä:
 *		mitä ominaisuuksia ja toimintoja tekisit Televisio-luokkaan?
 *		
 *		Toteuta Televisio-luokan ohjelmointi sekä pääohjelma,
 *		jolla luot olion Televisio-luokasta. Säädä luomaasi Televsio-oliota erilaisilla arvoilla,
 *		jätä Console.WriteLine()-tulostuslauseet ohjelmaasi, jotta televisio-olion käyttäminen jää näkyville.
 * Pvm: 18.1.2017
 */

using System;

namespace OOP.Tasks {
	class Program {
		static void Main(string[] args)
		{
			TelevisionFunc();
		}

		static void TelevisionFunc()
		{
			Television television1 = new Television();

			television1.IsOn = true;
			television1.HasSignal = true;
			television1.Channel = 1;
			television1.Volume = 0.70f;

			Console.WriteLine(television1.PrintStatus(television1));

			television1.Channel = 5;
			television1.Volume = 0.20f;
			Console.WriteLine(television1.PrintStatus(television1));
		}
	}
}
