using System;
/*using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;*/

namespace Harjoitus2
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Enter point qount >");
			int a = int.Parse(Console.ReadLine());
			if(a <= 1 && a >= 0) {
				Console.WriteLine("School number is 0");
			} else if (a > 1 && a <= 3) {
				Console.WriteLine("School number is 1");
			} else if (a > 3 && a <= 5) {
				Console.WriteLine("School number is 2");
			} else if (a > 5 && a <= 7) {
				Console.WriteLine("School number is 3");
			} else if (a > 7 && a <= 9) {
				Console.WriteLine("School number is 4");
			} else if (a > 9 && a <= 12) {
				Console.WriteLine("School number is 5");
			}
		}
	}
}
