/*
 * Tekijä: Juuso Huppunen
 * AsioID: K8960
 * Kurssi: TTOS0200
 * Harjoitus: OOP Labra 4 - Tehtävä 4
 * Kuvaus:
 *		Toteutettavassa sovelluksessa tulisi pystyä käsittelemään erilaisia kulkuneuvoja.
 *		Kaikilla kulkuneuvoilla on löydettävissä yhteisinä ominaisuuksina: nimi, malli, vuosimalli ja väri.
 *		Erikoistapauksina pitää pystyä käsittelemään polkupyöriä ja veneitä.
 *		Polkupyörän osalta pitää pystyä erottelemaan se,
 *		että onko kyseessä vaihdepyörä vai ei sekä mahdollisen vaihteiston mallinimi
 *		Veneiden osalta tietoina pitää ainakin olla veneen tyyppi (soutuvene, moottorivene, kajakki, ...)
 *		ja kuinka monta istuinpaikkaa veneestä löytyy.
 *		
 *		Tutki tehtävän tavoitetta/kerrontaa ja toteuta tarvittavat UML-luokkakaaviot.
 *		Toteuta tämän jälkeen vaaditut luokat, luo ja käytä olioita pääohjelmasta.
 *		Tulosta vaadittujen luokkien olioiden tietoja output-ikkunaan.
 *		Tietoja ei tarvitse kysyä sovelluksen käyttäjältä, vaan voit alustaa ne suoraan pääohjelmassa. 
 * Pvm: 22.1.2017
 */

using System;

namespace OOP.Tasks {
	class Program {
		static void Main(string[] args)
		{
			VehiclesDB();
		}

		static void VehiclesDB()
		{
			Bicycle bicycle = new Bicycle();
			bicycle.Name = "Nishiki";
			bicycle.Model = "Sports Bike";
			bicycle.AnnualModel = "Nishiki_Sports_2016";
			bicycle.Color = "Grey";
			bicycle.IsGeared = false;
			bicycle.GearModel = "SuperGears200";
			Console.WriteLine(bicycle.ToString());

			Console.WriteLine("-------------------------------------");

			Boat boat = new Boat();
			boat.Name = "SuperBoat12";
			boat.Model = "Fast01";
			boat.AnnualModel = "SuperBoat12_Fast01_2016";
			boat.Color = "Green";
			boat.BoatType = "Kajac";
			boat.Seats = 2;
			Console.WriteLine(boat.ToString() + "\n");
		}
	}
}
