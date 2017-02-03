
namespace OOP.Tasks {
	class Product {
		public string Name { get; set; }
		private float price;

		public float Price
		{
			get { return price; }
			set {
				price = value;
				if (price <= 0) {
					price = 0.01f;
				}
			}
		}

		public Product(string name, float price)
		{
			Name = name;
			Price = price;
		}

		public override string ToString()
		{
			string tmp = string.Format("Item name is {0}, and price is {1:0.00} euros", Name, Price);
			return tmp;
		}

	}
}
