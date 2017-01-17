/*
 * Tekijä: Juuso Huppunen
 * AsioID: K8960
 * Kurssi: TTOS0200
 * Harjoitus: OOP - Tehtävä 1
 * Kuvaus:
 *		Tehtävänäsi on ohjelmoida kiukaan toiminta.
 *		Kiuas pitää pystyä laittamaan päälle ja pois,
 *		sekä sen lämpötilaa että sen antamaa kosteutta pitää
 *		pystyä säätämään (arvoja ei ole rajattu).
 * Pvm: 16.1.2017
 */

using System;
using OOP.Classes;

namespace OOP.Tasks {
	class Program {
		static void Main(string[] args)
		{
			TestHeater();
		}
		static void TestHeater()
		{
			// Luodaan kiuas
			Heater heater = new OOP.Classes.Heater();
			// Laitetaan päälle
			heater.IsOn = true;
			heater.Termperature = 90f;
			heater.Humidity = 50f;

			// Näytetään konsolilla
			Console.WriteLine("Heater is on: {0}", heater.IsOn);
			Console.WriteLine("Heater's temperature: {0} C", heater.Termperature);
			Console.WriteLine("Heater's humidity: {0}", heater.Humidity);

			// Humidity overflow
			heater.Humidity = 101;
			Console.WriteLine("Heater's humidity: {0}", heater.Humidity);
		}
	}
}
