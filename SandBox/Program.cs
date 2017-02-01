using System;

namespace SandBox
{
	interface ICalculator {
		int Add(int number1, int number2);
		int Multiply(int number1, int number2);
	}
	class Program
	{
		static void Main(string[] args)
		{
		}
	}

	public class Calculator : ICalculator {
		public int Add(int n1, int n2)
		{
			return n1 + n2;
		}

		public int Multiply(int n1, int n2)
		{
			return n1 + n2;
		}
	}
}