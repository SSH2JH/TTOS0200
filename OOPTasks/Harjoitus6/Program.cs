/*
 * Tekijä: Juuso Huppunen
 * AsioID: K8960
 * Kurssi: TTOS0200
 * Harjoitus: OOP - Tehtävä 6
 * Kuvaus:
 *		Valitse jokin reaalimaailman asia ja suunnittele siitä luokkarakenne UML-editorilla.
 *		Tee uusi projekti. Ohjelmoi suunnittelema luokkasi sekä käytä tekemääsi luokkaa edellisten tehtävien mukaisesti.
 * Pvm: 17.1.2017
 */

using System;
/*using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;*/

namespace OOP.Tasks {
	class Program {
		static void Main(string[] args)
		{
			GameShopFunc();
		}
		static void GameShopFunc()
		{
			const int quantity = 2;
			GameShopItem[] game = new GameShopItem[quantity];
			for (int i = 0; i < quantity; i++) {
				game[i] = new GameShopItem();
			}

			for (int i = 0; i < quantity; i++) {
				Console.Write("\nPlease enter item id >");
				game[i].ItemId = Console.ReadLine();

				Console.Write("Please enter item name >");
				game[i].ItemName = Console.ReadLine();

				Console.Write("Please enter the amount of the items >");
				game[i].Available = int.Parse(Console.ReadLine());

				Console.Write("Please enter the value of the item >");
				game[i].Value = float.Parse(Console.ReadLine());
				Console.Write("-------------------------------------------\n");
			}

			for (int i = 0; i < quantity; i++) {
				game[i].PrintItem();
			}
		}
	}
}
