namespace GP20_2021_0413_BoolNumber {
	/// <summary>
	/// The Bool-Number is a bit-representation of a number as a bool array.
	/// Its size is 8 bits (1 Byte)
	/// It contains basic mathematical operations.
	/// </summary>
	public interface IBoolNumber {
		/// <summary>
		/// Returns an array containing true / false values for all
		/// </summary>
		bool[] Bits {get;}
    
		/// <summary>
		/// Adds two numbers and returns the result as a new BoolNumber-Object.
		/// This Object remains unchanged.
		/// </summary>
		/// <param name="addend">The number to add.</param>
		/// <returns>A new number that contains the Sum of this number and the addend.</returns>
		IBoolNumber Add(IBoolNumber addend);
    
		/// <summary>
		/// Subtracts two numbers and returns the result as a new BoolNumber-Object.
		/// This Object remains unchanged.
		/// </summary>
		/// <param name="subtrahend">The number to subtract.</param>
		/// <returns>A new number that contains the Subtract of this number and the subtrahend.</returns>
		IBoolNumber Subtract(IBoolNumber subtrahend);
    
		/// <summary>
		/// Returns a number that is half the size of this number.
		/// This Object remains unchanged.
		/// </summary>
		/// <returns>A new number that is half the size of this number.</returns>
		IBoolNumber DivideByTwo();
    
		/// <summary>
		/// Returns a number that is twice the size of this number.
		/// This Object remains unchanged.
		/// </summary>
		/// <returns>A new number that is twice the size of this number.</returns>
		IBoolNumber MultiplyWithTwo();
    
		/// <summary>
		/// Returns true, if the value is smaller than zero.
		/// </summary>
		/// <returns>True, if the value is smaller than zero.</returns>
		bool IsNegative();
    
		/// <summary>
		/// Returns true, if the this number is equal to the other number.
		/// </summary>
		/// <returns>True, if this number is equal to the other number.</returns>
		bool IsEqualTo(IBoolNumber other);
    
		/// <summary>
		/// Returns true, if the this number is grater than the other number.
		/// </summary>
		/// <returns>True, if this number is greater than the other number.</returns>
		bool IsGraterThan(IBoolNumber other);
    
		/// <summary>
		/// Returns true, if the this number is smaller than the other number.
		/// </summary>
		/// <returns>True, if this number is smaller than the other number.</returns>
		bool IsSmallerThan(IBoolNumber other);
    
		/// <summary>
		/// Returns a string that is formatted like this:
		/// 0b00000000 (0)
		/// Where 0b0000000 is the bit-representation
		/// And (0) the decimal representation of the number.
		/// </summary>
		/// <returns></returns>
		string ToString();
	}
}