/*
 * Tekijä: Juuso Huppunen
 * AsioID: K8960
 * Kurssi: TTOS0200
 * Harjoitus: OOP Labra 5 - Tehtävä 1
 * Kuvaus:
 *		Tee Rengas-luokka, jolla on seuraavat ominaisuudet: merkki, tyyppi ja rengaskoko.
 *		Tee tämän jälkeen Kulkuneuvo-luokka muutamilla kulkuneuvoon kuuluvilla ominaisuuksilla (nimi, malli)
 *		ja käytä tekemääsi Rengas-luokkaa apuna renkaiden käsittelyyn.
 *		Tässä vaiheessa voit koostaa kulkuneuvon renkaat Rengas-olioina esim. taulukkoon tai kurssimateriaalissa
 *		esitettyy List-rakenteeseen (kokoelmaluokat käsitellään tarkemmin seuraavissa demoissa).
 *		Tee pääohjelma, jossa luot muutamia kulkuneuvoja (esim. auto ja moottoripyörä) renkaineen.
 *		Tietoja ei tarvitse kysyä käyttäjältä, vaan voit alustaa niitä suoraan pääohjelman koodissa. 
 * Pvm: 23.1.2017
 */

using System;
/*using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;*/

namespace OOP.Tasks {
	class Program {
		static void Main(string[] args)
		{
			CarWithWheels();
		}
		static void CarWithWheels()
		{
			// create tyre
			Tire tire1 = new Tire { Vendor = "Nokia", Model = "Hakkapeliitta", TireSize = "205R16" };
			// create a car
			Car car1 = new Car { Name = "Porsche", Model = "911" };
			Console.WriteLine("Created a new car {0} {1}", car1.Name, car1.Model);
			Console.WriteLine(car1.AddTire(tire1));
			Console.WriteLine(car1.AddTire(tire1));
			Console.WriteLine(car1.AddTire(tire1));
			Console.WriteLine(car1.AddTire(tire1));
			Console.WriteLine(car1.AddTire(tire1));
			Console.WriteLine(car1.ToString());
		}
	}
}
