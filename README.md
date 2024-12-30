# Uninitialized Property Access in C#

This repository demonstrates a common, yet subtle, bug in C#: accessing a class property before it has been explicitly assigned a value. While properties have default values, relying on these defaults without explicit initialization can lead to unpredictable behavior and hard-to-debug issues.

The `bug.cs` file shows the problematic code.  The `bugSolution.cs` file demonstrates the proper way to handle property initialization to avoid this issue.

## How to Reproduce

1. Clone the repository.
2. Open `bug.cs` and run it.
3. Observe the output, and note the potential unexpected value.
4. Open `bugSolution.cs` and run it to see how to correctly initialize the property.

## Solutions

Always explicitly initialize class properties in the constructor or before accessing them. This removes ambiguity and makes the code's behavior clear and predictable.