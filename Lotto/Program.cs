using System;
using System.Collections.Generic;
using System.Linq;

namespace Lotto {
	class Program {
		static void Main(string[] args)
		{
			const int a = 7;
			Random rnd = new Random();
			int[] Numbers = new int[40];
			int[] WinNumbers = new int[a];
			int apu;
			for (int i = 0; i < Numbers.Length; i++) {
				Numbers[i] = i;
			}
			for (int i = 0; i < a; i++) {
				apu = rnd.Next(Numbers[39]);
				if (WinNumbers.Contains(apu)) {
					i--;
				} else {
					WinNumbers[i] = apu;
				}
			}
			Array.Sort(WinNumbers);
			for (int i = 0; i < a; i++) {
				Console.WriteLine(WinNumbers[i]);
			}
		}
	}
}
