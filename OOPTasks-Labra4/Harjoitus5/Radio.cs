using System;

namespace OOP.Tasks {
	class Radio {
		// Radio on/off
		public bool IsOn { get; set; }
		
		// Controls volume
		private int volume;
		public int Volume
		{
			get { return volume; }
			set {
				volume = value;
				if (IsOn == false || volume < 0) {
					volume = 0;
				} else if (volume > 9) {
					volume = 10;
				}
			}
		}

		// Controls frequency
		private double freq;
		public double Frequency
		{
			get { return freq; }
			set {
				freq = value;
				if (freq < 2000.0) {
					freq = 2000.0;
				} else if (freq > 26000.0) {
					freq = 26000.0;
				}
			}
		}

		// Outputs string
		public override string ToString()
		{
			string tmp = string.Format("Turned on: {0}, Volume: {1}/10, Analog frequency: {2:0.0} Hz", IsOn, Volume, Frequency);
			return tmp;
		}
	}
}
