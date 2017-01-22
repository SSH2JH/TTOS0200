/*
 * Tekijä: Juuso Huppunen
 * AsioID: K8960
 * Kurssi: TTOS0200
 * Harjoitus: OOP Labra 4 - Tehtävä 6
 * Kuvaus:
 *		ICT-opiskelijan kirjahyllystä löytyy vaikka mitä erilaisia tavaroita:
 *		kirjoja, lehtiä, cd-levyjä, dvd-levyjä, bluray-levyjä, puhelimia, tabletteja, läppäreitä, ... jne.
 *		Pohdi UML-kaaviota käyttäen millaisia luokkarakenteita
 *		(ainakin luokkien ja ominaisuuksien osalta) esiintyy ja käytä apuna perintää jos tavaroille
 *		löytyy yhteisiä ominaisuuksia. Toteuta tämän jälkeen muutamia luokkia,
 *		joissa perintää esiintyy. Tee myös pääohjelma, jossa käytät tekemiäsi luokkia ja luot olioita.
 * Pvm: 23.1.2017
 */

using System;

namespace OOP.Tasks {
	class Program {
		static void Main(string[] args)
		{
			BookShelfDB();
		}
		static void BookShelfDB()
		{
			Disk item1 = new Disk();
			item1.Name = "Metallica album";
			item1.Age = 5;
			item1.IsUseful = true;
			item1.Type = "Music - Rock";
			item1.Rating = 10;
			Console.WriteLine(item1.ToString());

			Console.WriteLine("\n-----------------------------------------------");

			Book item2 = new Book();
			item2.Name = "Eragon";
			item2.Age = 5;
			item2.IsUseful = true;
			item2.Genre = "Fantasy";
			item2.Pages = 600;
			Console.WriteLine(item2.ToString());
		}
	}
}
