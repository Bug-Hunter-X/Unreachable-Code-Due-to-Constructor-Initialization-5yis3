public class ExampleClass
{
    public int MyProperty { get; set; }

    public ExampleClass(int value)
    {
        MyProperty = value; // Initialize with a parameter
    }

    public void MyMethod()
    {
        if (MyProperty == 0)
        {
            Console.WriteLine("MyProperty is zero.");
        }
        else
        {
            Console.WriteLine("MyProperty is not zero.");
        }
    }

    public static void Main(string[] args)
    {
        ExampleClass obj1 = new ExampleClass(0); // Test case 1
        obj1.MyMethod();

        ExampleClass obj2 = new ExampleClass(10); // Test case 2
        obj2.MyMethod();
    }
}