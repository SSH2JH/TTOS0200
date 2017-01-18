using System;

namespace OOP.Tasks {
	class Elevator {
		int floor = 1;
		public int CurrentFloor
		{
			get { return floor; }
		}

		private string SwapValue(int newFloor)
		{
			// Tarkistaa että syöte on suurempi kuin nolla ja pienempi, tai yhtäsuuri kuin 5
			if (newFloor <= 5 && newFloor > 0) {
				floor = newFloor;
				return ("New floor is: " + CurrentFloor);
			}
			else {
				return ("Your value was out of reach!\n" + "Your current floor is: " + CurrentFloor);
			}
		}

		public string ChangeFloor(string input)
		{
			int inputNumeric;
			bool isNumeric;
			// Tarkistetaan käyttäjän syötteen nuumeerius
			isNumeric = int.TryParse(input, out inputNumeric);

			if (isNumeric == true) {
				// Tulostetaan uusi kerros ja vaihdetaan nykyisen kerroksen arvoa
				return SwapValue(inputNumeric);
			}
			else {
				// Yleinen virheviesti
				return ("Invalid value!");
			}
		}
	}
}
