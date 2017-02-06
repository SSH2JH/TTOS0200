using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Tasks {
	class FisherMan {
		public string Name { get; set; }
		public string PNumber { get; set; }

		public override string ToString()
		{
			string tmp = string.Format("Name: {0}, Phone number: {1}", Name, PNumber);
			return tmp;
		}
	}
	class Fish : FisherMan {
		public string Species { get; set; }

		private float length, weigth;
		public float Length
		{
			get { return length; }
			set {
				length = value;
				if (length < 0) {
					length = 0.01f;
				}
			}
		}
		public float Weight
		{
			get { return weigth; }
			set {
				weigth = value;
				if (weigth < 0) {
					weigth = 0.01f;
				}
			}
		}
		public override string ToString()
		{
			string tmp = string.Format("\nFish species: {0}, length: {1}, weigth: {2}", Species, Length, Weight);
			return base.ToString() + tmp;
		}

	}
}
