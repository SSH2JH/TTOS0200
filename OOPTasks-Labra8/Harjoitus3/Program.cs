/*
 * Tekijä: Juuso Huppunen
 * AsioID: K8960
 * Kurssi: TTOS0200
 * Harjoitus: OOP Labra 8 - Tehtävä 3
 * Kuvaus:
 *		 Toteuta sovellus, jossa voit hallita kalastukseen liittyviä tietoja.
 *		 Ohjelman pitää pystyä käsittelemään: saadun kalan perustiedot (laji, pituus ja paino),
 *		 kalastajan perustiedot (nimi, puhelinnumero) sekä saadun kalapaikan perustiedot (nimi ja paikka).
 *		 Pohdi tarvittava luokkarakenne UML-kaaviona.
 *		 Toteuta pääohjelmassa kalastaja ja muutamia kaloja. Tulosta lopuksi kalarekisterin sisältö. 
 * Pvm: 3.2.2017
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
			FisherSimulator();
		}
		static void FisherSimulator()
		{
			List<FisherMan> fisher1 = new List<FisherMan>();
			Fish fish1 = new Fish();
			fish1.Name = "Bob Fisher";
			fish1.PNumber = "505 123 1234";
			
			Console.WriteLine(fish1.ToString());
		}
	}
}
