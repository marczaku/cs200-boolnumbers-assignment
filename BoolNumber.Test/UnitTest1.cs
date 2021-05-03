using System;
using NUnit.Framework;

namespace GP20_2021_0413_BoolNumber.Test {
	public class Tests {
		[SetUp]
		public void Setup() {
		}

		[Test]
		public void Test1() {
			var boolNumber = new BoolNumber();
			Assert.Catch<System.NullReferenceException>(()=>boolNumber.Add(null));
		}

		[TestCase(0)]
		[TestCase(5), TestCase(3)]
		public void TestSomething(int number) {
			Console.WriteLine(number);
		}

		[Test]
		public void TestsIfParsingOfNumberZeroAndOneWorksCorrectly() {
			var zero = BoolNumber.FromNumber(0);
			Assert.False(zero.Bits[0]);
			var one = BoolNumber.FromNumber(1);
			Assert.True(one.Bits[0]);
		}
		
		// write tests for every new feature that you add :)
		// parses 5 correctly
		// parses -5 correctly
		// toString() works correctly
		// adding two positive numbers works
		// adding two negative numbers works...
	}
}