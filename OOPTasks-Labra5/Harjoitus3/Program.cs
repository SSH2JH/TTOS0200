/*
 * Tekijä: Juuso Huppunen
 * AsioID: K8960
 * Kurssi: TTOS0200
 * Harjoitus: OOP Labra 5 - Tehtävä 3
 * Kuvaus:
 *		Tehtävässä tulee toteuttaa muutamia luokkia, joiden avulla testataan abstraktien metodien toimivuutta.
 *		Luo abstrakti luokka Nisakas, jolla on Ika-ominaisuus sekä Liiku-metodi, jonka toteutus on jätetty toteuttamatta (abstrakti metodi).
 *		
 *		Peri Nisakas-luokasta Ihminen-luokka, jolla on ominaisuuksina ihmiseen yleisesti liittyviä ominaisuuksia (paino, pituus, nimi).
 *		Lisää Ihminen-luokkaan metodit: Liiku ja Kasva, joista ensimmäinen tulostaa ruutuun "liikun" ja jälkimmäinen lisää ihmisen ikää yhdellä vuodella.
 *		Huomioi, että Liiku-metodi ja Ikä-ominaisuus on Nisakas-luokassa
 *		
 *		Peri Ihminen-luokasta Vauva- ja Aikuinen-luokat. Ylikirjoita Vauva-luokassa yliluokan Liiku-metodi tulostamaan "konttaa".
 *		Ylikirjoita Aikuinen-luokassa myös sama metodi ja laita se tulostamaan "kävelee". Lisää aikuiselle ominaisuus auto (String). Lisää vauvalle ominaisuus vaippa (String).
 *		
 *		Toteuta pääohjelmassa muutamia ihmisiä, aikuisia ja vauvoja. Tulostele olioiden tietoja konsolille.
 * Pvm: 25.1.2017
 */

using System;

namespace OOP.Tasks {
	class Program {
		static void Main(string[] args)
		{
			Human Mej = new Human("Mej", 68, 165, 20);
			Baby Elina = new Baby("UltraDiaper", "Elina", 7, 40, 1);
			Adult Genji = new Adult("Ferrari", "Genji", 70, 170, 27);

			Console.WriteLine("{0} yells \"{1}\"", Mej.Name, Mej.Move());
			Console.WriteLine("{0} shouts \"{1}\"", Genji.Name, Genji.Move());
			Console.WriteLine("{0} screams \"{1}\"", Elina.Name, Elina.Move());

			Console.WriteLine("\n{0} the diaper is {1} and height is {2}", Elina.Name, Elina.Diaper, Elina.Height);
			Console.WriteLine("{0} car is {1} and is {2} year old", Genji.Name, Genji.Car, Genji.Age);
			Console.WriteLine("{0} weight is {1} and height {2}", Mej.Name, Mej.Weight, Mej.Height);
		}
	}
}
