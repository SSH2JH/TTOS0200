using System;
/*using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;*/

namespace OOP.Classes {
	public class Heater {
		public bool IsOn { get; set; }
		public float Termperature { get; set; }

		// Kosteus voi olla välillä 0-100%
		float humidity;
		public float Humidity {
			get { return humidity; }
			set {
				humidity = value;
				if (humidity < 0 || humidity > 100) {
					humidity = 0;
				}
			}
		}
	}
}
