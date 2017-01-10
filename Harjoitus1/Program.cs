using System;
/*using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;*/

namespace Harjoitus1
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Please enter a number >");
			int a = int.Parse(Console.ReadLine());

			switch (a) {
				case 1:
					Console.WriteLine("You entered number one!");
					break;
				case 2:
					Console.WriteLine("You entered number two!");
					break;
				case 3:
					Console.WriteLine("You entered number three!");
					break;
				default:
					Console.WriteLine("You entered some other number!");
					break;
			}
		}
	}
}
