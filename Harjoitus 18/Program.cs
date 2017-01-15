/*
 * Tekijä: Juuso Huppunen
 * AsioID: K8960
 * Kurssi: TTOS0200
 * Harjoitus: Tehtävä 18
 * Kuvaus:
 *		Tee ohjelma, joka kysyy käyttäjältä merkkijonon (lause).
 *		Sovelluksen tulee ilmoittaa käyttäjälle oliko annettu merkkijono palidromi. 
 * Pvm: 15.1.2017
 */

using System;
/*using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;*/

namespace Harjoitus_18 {
	class Program {
		static void Main(string[] args)
		{
			// Luodaan tarvittavat muuttujat ja kystytään käyttäjältä palindromia
			bool isPalindrome;
			Console.Write("This is palindrome tester, please enter a string >");
			string input = Console.ReadLine();
			// Tarkistaa onko käyttäjän syöte palindromi ja palauttaa true/false
			isPalindrome = IsPlaindrome(input);

			// Jos palinromi tulosta tämä ja jos ei else...
			if (isPalindrome == true) {
				Console.WriteLine("Your word was palindrome!");
			} else {
				Console.WriteLine("Your word wasn't a palindrome!");
			}
		}
		static bool IsPlaindrome(string str)
		{
			int i = 0;
			int j = str.Length - 1;

			// laskee str taulukkoa vasttakkaisista suunnista ja testaa kirjaimien yhteensopivuutta
			while (i < j) {
				if (str[i] != str[j]) {
					// mikäli ei palindromi...
					return false;
				}

				i++;
				j--;
			}
			// While looppi pääsee päätökseen mikäli se oli palindromi
			return true;
		}
	}
}