using System;

namespace OOP.Tasks {
	// Base class
	class Vehicle {
		public string Name { get; set; }
		public string Model { get; set; }
		public string AnnualModel { get; set; }
		public string Color { get; set; }

		public Vehicle()
		{
			// Default Constructor for base class
		}

		public override string ToString()
		{
			return Name + ", " + Model + ", " + AnnualModel + ", " + Color;
		}
	}

	// Inherited class for bicycles
	class Bicycle : Vehicle {
		private string gearModel;
		public bool IsGeared { get; set; }
		public string GearModel
		{
			get { return gearModel; }
			set {
				if (IsGeared == true) {
					gearModel = value;
				} else {
					gearModel = "n/a";
				}
			}
		}

		public Bicycle()
		{
			// Default constructor for inherited bicycle class
		}

		public override string ToString()
		{
			return base.ToString() + ".\nHas gears: " + IsGeared + ", " + GearModel;
		}
	}

	// Inherited class for boats
	class Boat : Vehicle {
		public string BoatType { get; set; }
		public int Seats { get; set; }

		public Boat()
		{
			// Default constructor for inherited boat class
		}

		public override string ToString()
		{
			return base.ToString() + ".\nBoat type: " + BoatType + ", Seats: " + Seats;
		}
	}
}
