# GP20-2021-0413-BoolNumber
BoolNumber-Assignment

### Task
Implement the `BoolNumber`-Class as required by the documentation.
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

### Where to Start?
- Start with `BoolNumber.FromNumber()`
- Then `BoolNumber.ToString()`

- See, if the first line in `Program.cs` looks good on the console output.

- Then implement `BoolNumber.Add()`.
- Continue implementing the other methods one by one.

- Add code to `Program.cs` to test, that your methods do, what you expect them to do.