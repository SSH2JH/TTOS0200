using System;

namespace OOP.Tasks {
	abstract class Mammal {
		public int Age { get; set; }

		public Mammal(int age)
		{
			Age = age;
		}
		public abstract string Move();
	}
	class Human : Mammal {
		public float Weight { get; set; }
		public float Height { get; set; }
		public string Name { get; set; }

		public Human(string name, float weight, float height, int age)
			: base (age)
		{
			Weight = weight;
			Height = height;
			Name = name;
		}
		public override string Move()
		{
			return "I move!";
		}
		public void Grow()
		{
			Age++;
		}
	}
	class Baby : Human {
		public string Diaper { get; set; }
		public Baby(string diaper, string name, float weight, float height, int age)
			:base (name, weight, height, age)
		{
			Diaper = diaper;
		}
		public override string Move()
		{
			return "I crawl!";
		}
	}
	class Adult : Human {
		public string Car { get; set; }
		public Adult(string car, string name, float weight, float height, int age)
			: base (name, weight, height, age)
		{
			Car = car;
		}
		public override string Move()
		{
			return "I walk!";
		}
	}
}
