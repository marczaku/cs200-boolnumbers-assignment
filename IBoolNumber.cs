namespace GP20_2021_0413_BoolNumber {
	/// <summary>
	/// The Bool-Number is a bit-representation of a signed number as a bool array.
	/// A 1 bit is represented as a true-bool and a 0 bit is represented as a false-bool.
	/// The least significant bit is at index 0 and the most significant bit at index 7.
	///
	/// ------------------
	/// SAMPLE_1
	/// The bits are ordered in the array like this:
	/// The representation of the bits 0b0101 would be new bool[]{true, false, true, false}
	/// The representation of the bits 0b111000 would be new bool[]{false, false, false, true, true, true}
	/// The representation of the bits 0b11 would be new bool[]{true, true}
	/// ------------------
	/// 
	/// Its size is always 8 bits (1 Byte)
	/// It may contain positive as well as negative numbers and zero.
	/// ------------------
	/// SAMPLE_2
	/// In other words: it can only hold bytes with 8 bits like this:
	/// The representation of the bits 0b11110000 would be
	///        new bool[]{false, false, false, false, true, true, true, true}
	/// The representation of the bits 0b01010101 would be
	///        new bool[]{true, false, true, false, true, false, true, false}
	///
	/// Representations with any other amount of bits are not supported by this class.
	/// (Therefore, the samples from SAMPLE_1 are invalid for this class)
	/// ------------------
	/// 
	///
	/// It should use the Two's Complement Notation.
	/// Hint: It has to do with how to store the information,
	/// whether a number is positive or negative.
	/// You only have eight bits available.
	/// 
	/// It contains basic mathematical operations.
	/// All mathematical operations are working directly on the bool-bits.
	///
	/// You are __NOT__ allowed to convert the bits to an Integer or any other format.
	/// And then let C# do the maths using + operators etc.
	/// I expect you to compare bits and do the maths line by line like this or similarly:
	/// if(other.bits[0] == true && this.bits[0] == true)
	/// 
	/// </summary>
	public interface IBoolNumber {
		/// <summary>
		/// Returns an array of exactly 8 Bits containing true / false values for all bits of this number
		/// </summary>
		bool[] Bits {get;}
		
		/// <summary>
		/// This number should ALWAYS return 8
		/// </summary>
		int NumberOfBits { get; }
    
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
		bool IsGreaterThan(IBoolNumber other);
    
		/// <summary>
		/// Returns true, if the this number is smaller than the other number.
		/// </summary>
		/// <returns>True, if this number is smaller than the other number.</returns>
		bool IsSmallerThan(IBoolNumber other);
    
		/// <summary>
		/// Returns a string that is formatted like this:
		/// "0b00000000 (0)"
		/// Where 0b0000000 is the bit-representation including leading zeros
		/// 00000000 are the values of all bits. Where true = 1 and false = 0.
		/// The smallest bit is always at the last index (marked with s in the next sample)
		/// The largest bit is always at the first index (marked with l in the next sample)
		/// "0bl000000s (0)"
		/// And (0) the decimal representation of the number. No leading zeros.
		/// For negative numbers, the string is formatted like this:
		/// "0b00000000 (-1)"
		/// </summary>
		/// <returns></returns>
		string ToString();
	}
}