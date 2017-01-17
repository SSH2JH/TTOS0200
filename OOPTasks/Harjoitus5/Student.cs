using System;

namespace OOP.Tasks {
	public class Student {

		// Parametrit nini,
		public string Name { get; set; }
		// id,
		public string StudentId { get; set; }
		// pääaine,
		public string MainSubject { get; set; }
		// onko läsnä lukukaudessa
		public bool IsActive { get; set; }

		// Tulostaa parametrit
		public void PrintStudent()
		{
			Console.WriteLine("\nName: {0}", Name);
			Console.WriteLine("ID: {0}", StudentId);
			Console.WriteLine("Main Subject: {0}", MainSubject);
			Console.WriteLine("Attending: {0}", IsActive);
			Console.WriteLine("--------------------------------");
		}
	}
}
