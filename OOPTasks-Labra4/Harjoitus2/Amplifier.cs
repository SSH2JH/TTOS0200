using System;

namespace OOP.Tasks {
	class Amplifier {
		private string AmpName { get; set; }
		private int volume;

		public int AmpVolume
		{
			get { return volume; }
			set {
				volume = value;
				if ( volume < 0 || volume > 100) {
					volume = 0;
				}
			}
		}

	}
}
