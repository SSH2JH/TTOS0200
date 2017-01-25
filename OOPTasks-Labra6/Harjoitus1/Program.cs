using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Tasks.T1 {
	class Program {
		static void Main(string[] args)
		{
			TestPersonRegistry();
		}
		static void TestPersonRegistry()
		{
			// Creating few test persons
			Persons crowd = new Persons();
			Person prs1 = new Person { FirstName = "Micael", Lastname = "Landry", PersonID = "131232-1212A" };
			Person prs2 = new Person { FirstName = "Lucy", Lastname = "Russel", PersonID = "121311-112312" };
			Person prs3 = new Person { FirstName = "Creature", Lastname = "Cat", PersonID = "131231-23543B" };
			// Add people to crowd
			crowd.AddPerson(prs1);
			crowd.AddPerson(prs2);
			crowd.AddPerson(prs3);

			foreach (Person x in crowd.PersonList) {
				Console.WriteLine("{0}", x.ToString());
			}
			// TODO ask the client for person id, search it and print it (FINISHED)
			Console.Write("Please enter person ID >");
			string a = Console.ReadLine();
			Console.WriteLine(String.Format("\nSearch result: " + crowd.GetPersonID(a)));
		}
	}
}
