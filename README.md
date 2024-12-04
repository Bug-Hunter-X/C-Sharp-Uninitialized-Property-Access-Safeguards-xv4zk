# C# Uninitialized Property Access

This repository demonstrates an uncommon error in C#: accessing a property of a class before it has been initialized.  Uninitialized properties can lead to unexpected behavior, particularly when dealing with value types. 

The `bug.cs` file shows the problematic code. The `bugSolution.cs` file demonstrates how to correctly handle this situation using null-coalescing and conditional checks. 

## How to Reproduce the Bug
1. Clone this repository.
2. Compile and run the `bug.cs` file. Observe that it either throws an exception if the property is a reference type or prints an unpredictable value for a value type.

## Solution
The solution, implemented in `bugSolution.cs`, uses null-coalescing to provide a default value and a conditional check to ensure the property is initialized before usage. This prevents the unpredictable behavior.