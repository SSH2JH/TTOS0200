/*
 * Tekijä: Juuso Huppunen
 * AsioID: K8960
 * Kurssi: TTOS0200
 * Harjoitus: OOP - Tehtävä 5
 * Kuvaus:
 *		Suunnittele UML-editorilla Opiskelija-luokka,
 *		joka sisältää opiskelijalle tyypillisiä tietoja ja toimintoja.
 *		Tee uusi projekti. Ohjelmoi Opiskelija-luokka sekä toteuta pääohjelma,
 *		joka luo muutamia opiskelijoita ja tallentaa opiskelijat taulukkoon (esim. 5 opiskelijaa).
 *		Tulosta taulukossa olevien opiskelijoiden tiedot käyttämällä toistorakennetta.
 * Pvm: 17.1.2017
 */

using System;

namespace OOP.Tasks {
	class Program {
		static void Main(string[] args)
		{
			StudentDatabase();
		}
		static void StudentDatabase()
		{
			// Määrittää taulukon koon
			const int quantity = 5;

			// Aloittaa olion taulukon ja sen sisällöt
			Student[] students = new Student[quantity];
			for (int i = 0; i < quantity; i++) {
				students[i] = new Student();
			}

			// Asettaa olion parametreille arvot

			// 1. student
			students[0].Name = "Tony Russel";
			students[0].StudentId = "001";
			students[0].MainSubject = "Programming";
			students[0].IsActive = true;
			// 2. student
			students[1].Name = "Lucy O'Doherty";
			students[1].StudentId = "002";
			students[1].MainSubject = "Psychology";
			students[1].IsActive = true;
			// 3. student
			students[2].Name = "Matt Mathewson";
			students[2].StudentId = "003";
			students[2].MainSubject = "Math";
			students[2].IsActive = false;
			// 4. student
			students[3].Name = "Ned Lannister";
			students[3].StudentId = "004";
			students[3].MainSubject = "History";
			students[3].IsActive = true;
			// 5. student
			students[4].Name = "Some Random Lass";
			students[4].StudentId = "005";
			students[4].MainSubject = "Programming";
			students[4].IsActive = true;

			// Tulostaa tietokannan, siis taulukon
			for (int i = 0; i < quantity; i++) {
				Console.WriteLine(students[i].PrintStudent());
			}
		}
	}
}
