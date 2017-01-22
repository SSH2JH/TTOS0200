using System;

namespace OOP.Tasks {
	class Amplifier {
		// Asioita täällä
		private string AmpName { get; set; }

		// setterille suojattu property
		private int volume;
		public int AmpVolume
		{
			get { return volume; }
			set {
				volume = value;
				if ( volume < 0) {
					volume = 0;
				} else if (volume > 100) {
					volume = 100;
				}
			}
		}
		// Constructor
		public Amplifier(string name, int initVolume)
		{
			AmpName = name;
			AmpVolume = initVolume;
		}
		// Palauttaa ampin tiedot
		public string PrintStatus()
		{
			return "Ampifier name: " + AmpName + ", Volume is: " + AmpVolume + "%";
		}
	}
}
