using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Tasks.T1 {
	/// <summary>
	/// This class contains person poperties
	/// </summary>
	class Person {
		public string FirstName { get; set; }
		public string Lastname { get; set; }
		public string PersonID { get; set; }

		public override string ToString()
		{
			return FirstName + " " + Lastname + " " + PersonID;
		}
	}
	/// This class holds person information in a collection
	class Persons {
		// properties
		private List<Person> persons;
		public List<Person> PersonList {
			get { return persons; }
		}
		public Persons()
		{
			persons = new List<Person>();
		}
		public void AddPerson(Person person)
		{
			persons.Add(person);
		}
		public Person GetPerson(int index)
		{
			if (index < persons.Count) {
				return persons.ElementAt(index);
			} else {
				return null;
			}
		}
		public Person GetPersonID(string id)
		{
			foreach (Person person in persons) {
				if (person.PersonID == id) {
					return person;
				}
			}
			return null;
		}
	}
}
