/*
 * Tekijä: Juuso Huppunen
 * AsioID: K8960
 * Kurssi: TTOS0200
 * Harjoitus: OOP - Tehtävä 2
 * Kuvaus:
 *		Tehtävänäsi on ohjelmoida pesukoneen toiminta.
 *		Samoin kuin edellinen tehtävä: mitä ominaisuuksia ja toimintoja tekisit Pesukone-luokkaan?
 *		
 *		Toteuta Pesukone-luokan ohjelmointi sekä pääohjelma,
 *		jolla luot olion Pesukone-luokasta. Säädä pesukone-oliota erilaisilla arvoilla,
 *		jätä Console.WriteLine()-tulostuslauseet ohjelmaasi,
 *		jotta pesukone-olion käyttäminen jää näkyville. Toteuta Pesukone-luokkaan muutamia erilaisia konstruktoreita
 *		ja alusta niitä käyttämällä oliota pääohjelmasta käsin.
 * Pvm: 18.1.2017
 */

using System;

namespace OOP.Tasks {
	class Program {
		static void Main(string[] args)
		{
			LaundryMachineFunc();
		}

		static void LaundryMachineFunc()
		{
			LaundryMachine lMachine = new LaundryMachine();
			lMachine.IsOn = true;
			lMachine.RotationSpeed = 1400;
			lMachine.ProgramLenght = 90;
			lMachine.Temperature = 60;

			Console.WriteLine(lMachine.PrintProgram(lMachine));

		}
	}
}
