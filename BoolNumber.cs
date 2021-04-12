namespace GP20_2021_0413_BoolNumber {
	/// <inheritdoc cref="IBoolNumber"/>
	public class BoolNumber : IBoolNumber {
		/// <summary>
		/// Returns the Maximum possible value for a BoolNumber.
		/// </summary>
		public static IBoolNumber Max {
			get {
				throw new System.NotImplementedException();
			}
		}
		/// <summary>
		/// Returns the Minimum possible value for a BoolNumber.
		/// </summary>
		public static IBoolNumber Min {
			get {
				throw new System.NotImplementedException();
			}
		}

		/// <summary>
		/// Returns a BoolNumber for the passed value.
		/// </summary>
		/// <param name="number">The value of the bool number</param>
		/// <returns>The BoolNumber representing the passed value</returns>
		public static IBoolNumber FromNumber(sbyte number) {
			// sbyte has numbers from ca. -120 to ca. + 120.
			// I want you to do a for loop and check the number in order to set the bits manually.
			// One by one.
			// if you get the number 17 and you want to convert it to binary, how would you do that?
			// do the same in code.
			throw new System.NotImplementedException();
		}
	}
}