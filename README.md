# GP20-2021-0412-BoolNumber
BoolNumber-Assignment

In class, we have learned about:
- The decimal system:
    - 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11...
- The binary system:
    - 0, 1, 10, 11, 100, 101, ...
    - That the binary system has an infinite amount of similarities to the decimal system:
        - Multiplying with 2 similar to multiplying with 10 in Decimal.
        - 2 in Binary is actually written as 10.
        - Adding numbers works the same
        - Subtracting numbers works the same
        - The highest number that can fit in x digits
- Why computers use the binary system:
    - The simplest numeric system possible
    - Makes the amount of possible different logical switches low
    - most safe to measure electric switches in only two states
- How computers use bits to store information
    - 1 Byte = 8 Bits
    - Numbers can simply be stored in different amount of bytes:
        - 1 Byte (`byte`) = [0..255]
        - 2 Byte (`ushort`) = [0..65025]
        - 4 Byte (`uint`) = [0..4.x billion]
    - Negative numbers are more complicated
        - We need to store the information, whether a number is negative or positive somehow
        - We can use one bit for that
        - Which means, that in one byte, we only have 7 bits left to express the actual number: [-127..+127?]
        - We get `-0` and `-0` this way
    - The solution to the problem: `Two's Compliment Notation`
        - Positive numbers all remain the same (but you cannot use the most significant (highest) bit)
        - Negative numbers are expressed by
            - Taking the positive number: 011 (3)
            - Inverting it: 100 (-2)
            - And adding one to it: 101 (-3)
        - Play around with that!
            - `-0` no longer exists
            - Adding two numbers works almost magically
            - By utilizing bit overflow
                - which describes the process of losing information due to running out of bits
    
Now it's your time to put this knowledge to use!\
We want to implement our own binary representation of a number.\
The `BinaryBool`-Class is documented in the code.\
In general, you are supposed to convert a number to a bool-array that represents the bits of a number in Memory.\
    

### Task
Implement the `BoolNumber`-Class as required by the documentation.\
There is a handful of Methods and Properties defined in the `BoolNumber`-`class`.\
And another handful in the `IBoolNumber`-`interface`.\
Interfaces are a great way of defining / documenting, what a class's implementation is supposed to look like.\
Use the `Program`-Class to test your implementation.

### Important!
Do not change the interface, unless officially changed by me. I expect to be able to use the class using the defined interface.

### Bonus-Assignments:
- Implement an `Indexer` (the `[]`-operator).
- Implement mathematical operators `+`, `-`.
- Implement comparison operators `==`, `!=` `<`, `<=`, `>`, `>=`
- Implement `Exception`-handling for positive and negative (unintended) overflows. (This trains error handling skills)
- Write Unit Tests for your implementation. (You should actually do this anyways)
- Implement the `IEnumerable`-interface. (It would make a lot of sense for a class like this, to allow easier enumeration over the bits)
- Implement an alternative implementation using a `struct` instead of a `class` (It would make much more sense in this case)

### First steps

Clone this repository to your computer (in `GitHub Desktop` or any other Git-Client.)\
Open the `.csproj`-File in the root of this repository (in `Jetbrains Rider` or any other C# IDE)\
Take a look at the `BoolNumber`-class. Many Properties and Methods are not implemented, yet. Also, the `BoolNumber`-class implements the `IBoolNumber`-interface, but does not contain the interface's methods, yet.

### Further help

Start by adding an empty implementation of the interface to your `BoolNumber`-class (your IDE should be able to do that for you).\
Then, I recommend these steps to get started:
- First, implement the `BoolNumber.FromNumber()`-Method, so you can create numbers from `sbytes`. `sbyte` is C#'s class representation of a signed number that can be stored in 1 byte. So, it's perfect for our exercise. You will have to convert a decimal number to a binary number to do this.
    - You can work your way step by step:
        - Make sure, that an input of `0` returns the correct number
        - Next, try `1`, `2`, `3`, ...
        - Next, try `-1,`, `-3`, ...
- Next, implement `BoolNumber.ToString()`-Method, so you can easily print the value of your `BoolNumbers` to the Console.
    - Start with printing the Binary-Part first.
    - Then think about how to print the Decimal representation. You will have to convert a binary number to a decimal number to do this.
- Now, work your way through the remaining methods in any order you like.