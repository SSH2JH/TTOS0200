using System;

namespace OOP.Tasks {
	class LaundryMachine {
		public bool IsOn { get; set; }
		public int RotationSpeed { get; set; }
		public int ProgramLenght { get; set; }
		public float Temperature { get; set; }

		public string PrintProgram(LaundryMachine x)
		{
			// x edustaa tuntematonta oliota joka syötetään pääohjelmasta
			return String.Format("Is on: {0}, RPM: {1}, Program Time: {2} min, Temperature {3} C",
				x.IsOn, x.RotationSpeed, x.ProgramLenght, x.Temperature);
		}
	}
}
