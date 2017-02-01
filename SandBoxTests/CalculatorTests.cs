using Microsoft.VisualStudio.TestTools.UnitTesting;
using SandBox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SandBox.Tests {
	[TestClass()]
	public class CalculatorTests {
		[TestMethod()]
		public void AddTest()
		{
			/// AAA Periaate
			/// A = Arrange, tietojen alustus
			/// A = act, kutsutaan metodia
			/// A = assert, varmistetaan että tulos ok

			// Arrange
			Calculator calc = new Calculator();
			int a = 4;
			int b = 5;
			int expected = 9;
			// Act
			int actual = calc.Add(a, b);
			// Assert
			Assert.AreEqual(expected, actual);
		}

		[TestMethod()]
		public void MultiplyTest()
		{
			// Arrange
			Calculator calc = new Calculator();
			int a = 4;
			int b = 5;
			int expected = 20;
			// Act
			int actual = calc.Add(a, b);
			// Assert
			Assert.AreEqual(expected, actual);
		}
	}
}