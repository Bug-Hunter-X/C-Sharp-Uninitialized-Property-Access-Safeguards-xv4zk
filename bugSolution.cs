public class ExampleClass
{
    public int MyProperty { get; set; }

    public void MyMethod()
    {
        // Solution: Use null-coalescing assignment to provide a default value
        int value = MyProperty ?? 0; 
        Console.WriteLine(value); // Now, it prints 0 if MyProperty is not set

        // Alternative solution: Use a conditional check
        if (MyProperty != 0) // Assuming 0 is the default or a meaningful default
        {
            int value2 = MyProperty;
            Console.WriteLine(value2); 
        } else
        {
            Console.WriteLine("Property is not initialized");
        }
    }
} 