using System;

namespace OOP.Tasks {
	/// <summary>
	/// Acts as dice class.
	/// </summary>
	class Dice {
		private Random rnd = new Random();
		private int result;

		/// <summary>
		/// Mehtod controls dice randomization
		/// </summary>
		public int ThrowDice()
		{
			result = rnd.Next(1,7);
			return result;
		}
	}
}
