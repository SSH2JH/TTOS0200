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
		public string PrintStudent()
		{
			return ("\nName: " + Name +
				"\nID: " + StudentId + 
				"\nMain Subject: " + MainSubject +
				"\nAttending: " + IsActive +
				"\n---------------------------------");
		}
	}
}
