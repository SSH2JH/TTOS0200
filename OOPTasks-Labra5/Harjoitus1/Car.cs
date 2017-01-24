using System;
using System.Collections.Generic;

namespace OOP.Tasks {
	class Car {
		public string Name { get; set; }
		public string Model { get; set; }
		private const int MaxTires = 4;
		private int TireAmount = 0;

		public List<Tire> Tires { get; }

		public Car()
		{
			Tires = new List<Tire>();
		}

		public string AddTire(Tire tire)
		{
			if (TireAmount < MaxTires) {
				Tires.Add(tire);
				TireAmount++;
				string tmp = string.Format("Tire {0} added to vehicle {1}", tire.Model, Name);
				return tmp;
			} else {
				return "Error! Max tire amount has been reached!";
			}
		}
		public override string ToString()
		{
			string s = "Car: " + Name + " Model :" + Model + "\nTires:";
			foreach (Tire r in Tires) {
				if (r != null) s += "\n-" + r.ToString();
			}
			return s;
		}
	}
	class Tire {
		public string Vendor { get; set; }
		public string Model { get; set; }
		public string TireSize { get; set; }

		public override string ToString()
		{
			return "Vendor: " + Vendor + ", model: " + Model + ", tire size: " + TireSize;
		}
	}
}