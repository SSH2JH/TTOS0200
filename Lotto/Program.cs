using System;

namespace Lotto {
	class Program {
		static void Main(string[] args)
		{
			Random rnd = new Random();
			int[] Numbers = new int[7];

			for (int i = 0; i < 7; i++) {
				Numbers[i] = rnd.Next(1,40);
			}

			for (int i = 0; i < 7; i++) {
				Console.WriteLine(Numbers[i]);
			}
		}
	}
}
