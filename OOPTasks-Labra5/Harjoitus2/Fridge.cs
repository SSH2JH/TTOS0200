using System;
using System.Collections.Generic;

namespace OOP.Tasks {
	class Fridge {
		public bool IsOn { get; set; }
		private int ItemQuantity = 0;
		private int MaxItems = 25;
		public List<FridgeItem> Items { get; }
		// Secured property
		private float temperature;
		public float Temperature
		{
			get { return temperature; }
			set {
				temperature = value;
				if (IsOn == false) {
					temperature = 0;
				}
				else if (temperature > 8) {
					temperature = 8;
				}
				else if (temperature < 0) {
					temperature = 0;
				}
			}
		}
		public Fridge()
		{
			Items = new List<FridgeItem>();
		}

		public string AddItem(FridgeItem item)
		{
			if (ItemQuantity < MaxItems) {
				Items.Add(item);
				ItemQuantity++;
				return "New item " + item.Name + " added to fridge";
			} else {
				return "Error! Max item quantity reached!";
			}
		}

		public string PrintAll()
		{
			return "Fridge - Turned on: " + IsOn + ", Items: " + ItemQuantity + ", temperature: +" + Temperature + " C";
		}
	}
	class FridgeItem {
		public string Name { get; set; }
	}
}
