using System;

namespace OOP.Tasks {

	// Pääluokka
	class Employee {
		public string Name { get; set; }
		public string Profession { get; set; }
		public float Salary { get; set; }

		public Employee()
		{
		}

		public override string ToString()
		{
			return Name + ", " + Profession + ", " + Salary + " euros/h";
		}
	}

	// Periytyvä luokka
	class Boss : Employee {
		public string Car { get; set; }
		public float Bonus { get; set; }

		public Boss()
		{
		}

		public override string ToString()
		{
			return base.ToString() + " + " + Bonus + " euros/month" + ", " + Car;
		}
	}
}
