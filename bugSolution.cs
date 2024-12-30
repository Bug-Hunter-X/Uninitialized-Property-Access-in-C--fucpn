public class ExampleClass
{
    public int MyProperty { get; set; }

    public ExampleClass() // Constructor to initialize the property
    {
        MyProperty = 10; // Explicit initialization
    }

    public void MyMethod()
    {
        Console.WriteLine(MyProperty); // Now this will print 10 reliably.
    }
}