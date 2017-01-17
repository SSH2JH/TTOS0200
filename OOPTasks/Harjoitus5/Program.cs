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
			Student[] student = new Student[quantity];
			for (int i = 0; i < quantity; i++) {
				student[i] = new Student();
			}

			// Asettaa olion parametreille arvot

			// 1. student
			student[0].Name = "Tony Russel";
			student[0].StudentId = "001";
			student[0].MainSubject = "Programming";
			student[0].IsActive = true;
			// 2. student
			student[1].Name = "Lucy O'Doherty";
			student[1].StudentId = "002";
			student[1].MainSubject = "Psychology";
			student[1].IsActive = true;
			// 3. student
			student[2].Name = "Matt Mathewson";
			student[2].StudentId = "003";
			student[2].MainSubject = "Math";
			student[2].IsActive = false;
			// 4. student
			student[3].Name = "Ned Lannister";
			student[3].StudentId = "004";
			student[3].MainSubject = "History";
			student[3].IsActive = true;
			// 5. student
			student[4].Name = "Some Random Lass";
			student[4].StudentId = "005";
			student[4].MainSubject = "Programming";
			student[4].IsActive = true;

			// Tulostaa tietokannan, siis taulukon
			for (int i = 0; i < quantity; i++) {
				student[i].PrintStudent();
			}
		}
	}
}
