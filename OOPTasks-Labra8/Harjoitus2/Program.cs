/*
 * Tekijä: Juuso Huppunen
 * AsioID: K8960
 * Kurssi: TTOS0200
 * Harjoitus: OOP Labra 8 - Tehtävä 2
 * Kuvaus:
 *		 Toteuta sovellus, jolla voit hallita ostoskärryn sisältöä.
 *		 Ostettavalta tuotteelta riittää käsitellä nimi ja hinta.
 *		 Toteuta Product-luokka ja lisää pääohjelmassa esimerkiksi:
 *		 List-tietorakenteeseen muutamia Product-luokan oliota.
 *		 Tulosta lopuksi kokoelman sisältö. 
 * Pvm: 3.2.2017
 */

using System;
using System.Collections.Generic;

namespace OOP.Tasks {
	class Program {
		static void Main(string[] args)
		{
			ShoppingCartTest();
		}
		static void ShoppingCartTest()
		{
			Product Milk = new Product("Milk", 3.551f);
			Product Cheece = new Product("Cheese", 5.5f);
			Product Beer = new Product("Beer", 3.5f);
			List<Product> ShoppingCart = new List<Product>();
			// Added items

			ShoppingCart.Add(Milk);
			ShoppingCart.Add(Cheece);
			ShoppingCart.Add(Beer);
			// Some cool chages

			Beer.Price = -5.4f;
			ShoppingCart.Remove(Milk);
			// Printing out the shopping cart

			foreach (Product x in ShoppingCart) {
				Console.WriteLine(x.ToString());
			}
		}
	}
}
