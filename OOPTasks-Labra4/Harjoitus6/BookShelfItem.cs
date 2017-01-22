using System;

namespace OOP.Tasks {
	class BookShelfItem {
		public string Name { get; set; }
		public int Age { get; set; }
		public bool IsUseful { get; set; }

		public override string ToString()
		{
			return Name + ": Age " + Age + " years, Useful " + IsUseful;
		}
	}
	class Disk : BookShelfItem {
		public string Type { get; set; }

		private int rating;
		public int Rating
		{
			get { return rating; }
			set {
				rating = value;
				if (rating < 0) {
					rating = 0;
				} else if (rating > 10) {
					rating = 10;
				}
			}
		}

		public override string ToString()
		{
			string tmp = string.Format("\n\tType {0}, Rating {1}/10", Type, Rating);
			return base.ToString() + tmp;
		}

	}
	class Book : BookShelfItem {
		public string Genre { get; set; }
		public int Pages { get; set; }

		public override string ToString()
		{
			string tmp = string.Format("\n\tGenre {0}, Pages {1}", Genre, Pages);
			return base.ToString() + tmp;
		}
	}
}
