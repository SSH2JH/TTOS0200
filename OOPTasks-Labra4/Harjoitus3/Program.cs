/*
 * Tekijä: Juuso Huppunen
 * AsioID: K8960
 * Kurssi: TTOS0200
 * Harjoitus: OOP Labra 4 - Tehtävä 3
 * Kuvaus:
 *		Ohjelmassa tulee pystyä käsittelemään työntekijöiden tietoja (Employee).
 *		Työntekijöiden osalta seuraavia tietoa pitää pystyä käsittelemään:
 *		työntekijän nimi (Name), työntekijän ammatti (Profession) ja palkka (Salary).
 *		Samassa ohjelmassa pitää pystyä käsittelemään myös johtajien tietoja (Boss),
 *		heillä on edellisten lisäksi myös auto (Car) ja palkkabonus (Bonus).
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
			WorkPlaceStaff();
		}

		static void WorkPlaceStaff()
		{
			Console.WriteLine("Name, Profession, Salary, Bonus, Car");
			Console.WriteLine("-----------------------------------------------");

			Employee employee1 = new Employee();
			employee1.Name = "Henri Jokinen";
			employee1.Profession = "Programmer";
			employee1.Salary = 14.82f;
			Console.WriteLine(employee1.ToString());

			Console.WriteLine("-----------------------------------------------");

			Employee employee2 = new Employee();
			employee2.Name = "Keijo Nieminen";
			employee2.Profession = "Senior Programmer";
			employee2.Salary = 19.82f;
			Console.WriteLine(employee2.ToString());

			Console.WriteLine("-----------------------------------------------");

			Boss boss1 = new Boss();
			boss1.Name = "Matti Järvinen";
			boss1.Profession = "CEO";
			boss1.Car = "Audi";
			boss1.Salary = 30.45f;
			boss1.Bonus = 650.12f;
			Console.WriteLine(boss1.ToString());

			Console.WriteLine("-----------------------------------------------");

			Boss boss2 = new Boss();
			boss2.Name = "Tero Syvänne";
			boss2.Profession = "Project Manager";
			boss2.Car = "Mercedes Benz";
			boss2.Salary = 28.45f;
			boss2.Bonus = 350.12f;
			Console.WriteLine(boss2.ToString());

			Console.WriteLine("-----------------------------------------------");
		}
	}
}
