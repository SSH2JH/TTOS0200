using System;

namespace OOP.Tasks {
	class GameShopItem {
		public string ItemId { get; set; }
		public string ItemName { get; set;}
		public int Available { get; set; }
		public float Value { get; set; }

		public void PrintItem()
		{
			Console.WriteLine("\nID: {0}", ItemId);
			Console.WriteLine("Item Name: {0}", ItemName);
			Console.WriteLine("Available: {0}", Available);
			Console.WriteLine("Value: {0:0.00} $", Value);
			Console.WriteLine("--------------------------------");
		}
	}
}
