using System;

namespace SandBox
{
	class Program
	{
		static void Main(string[] args)
		{
			// Laskutoimituksia taulokon arvoilla
			Calculations();
			// Array of string
			ShowNames();
		}
		static void ShowNames()
		{
			// Luodaan taulukko
			string[] Names = new string[5];

			// Kysytään 5 nimeä
			for (int i = 0; i <= 4; i++) {
				Console.Write("Please enter {0}. name: ", (i + 1));
				Names[i] = Console.ReadLine();
			}

			// Asetetaan taulukon arvot oikeaan järjestykseen
			Array.Sort(Names);

			// Tulostetaan järjestetty taulukko
			for (int i = 0; i <= 4; i++) {
				Console.Write(Names[i] + " ");
			}

			Console.WriteLine("\nOhjelma suoritettu onnistuneesti!");
		}
		static void Calculations()
		{
			int[] nums = { 2, 3, 6 };
			Console.Write("The sum of {0} * {1} * {2} is: {3}\n", nums[0], nums[1], nums[2], (nums[0] * nums[1] * nums[2]));
		}
	}
}