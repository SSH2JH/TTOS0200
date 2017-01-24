/*
 * Tekijä: Juuso Huppunen
 * AsioID: K8960
 * Kurssi: TTOS0200
 * Harjoitus: OOP Labra 5 - Tehtävä 2
 * Kuvaus:
 *		Pohdi jääkaappia reaalimaailman käsitteenä ja erityisesti sitä mitä sieltä löytyy.
 *		Tee pienimuotoinen toteutus, joka koostaa jääkaapin sisältöä muutamista eri asioista/olioista.
 * Pvm: 23.1.2017
 */

using System;

namespace OOP.Tasks {
	class Program {
		static void Main(string[] args)
		{
			FridgeFunc();
		}
		static void FridgeFunc()
		{
			Fridge fridge1 = new Fridge();
			fridge1.IsOn = true;
			fridge1.Temperature = 4;

			FridgeItem milk = new FridgeItem { Name = "Milk" };
			FridgeItem bread = new FridgeItem { Name = "Bread" };
			Console.WriteLine(fridge1.AddItem(milk));
			Console.WriteLine(fridge1.AddItem(milk));
			Console.WriteLine(fridge1.AddItem(milk));
			Console.WriteLine(fridge1.AddItem(bread));
			Console.WriteLine(fridge1.AddItem(bread));
			Console.WriteLine(fridge1.AddItem(bread));
			Console.WriteLine(fridge1.PrintAll());
		}
	}
}
