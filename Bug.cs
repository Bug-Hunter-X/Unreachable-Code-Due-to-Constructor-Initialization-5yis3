public class ExampleClass
{
    public int MyProperty { get; set; }

    public ExampleClass()
    {
        // Initialize MyProperty to a non-zero value
        MyProperty = 10;
    }

    public void MyMethod()
    {
        if (MyProperty == 0)
        {
            // This code will never execute because MyProperty is always initialized to 10 in the constructor.
            Console.WriteLine("MyProperty is zero.");
        }
        else
        {
            Console.WriteLine("MyProperty is not zero.");
        }
    }
}