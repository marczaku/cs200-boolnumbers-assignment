using System;

namespace GP20_2021_0413_BoolNumber {
	class Program {
		static void Main(string[] args) {
			Console.WriteLine("Good luck! And have fun!");
			var boolNumber = BoolNumber.FromNumber(17);
			Console.WriteLine("17 as a BoolNumber is: " + boolNumber.ToString());

			var seven = BoolNumber.FromNumber(7);
			var five = BoolNumber.FromNumber(5);
			var twelve = seven.Add(five);

			Console.WriteLine("7 should still be 7: " + seven);
			Console.WriteLine("5 should still be 5: " + five);
			Console.WriteLine("7+5 should be 12: " + twelve);
		}
	}
}