public class MyClass
{
    // TODO: Declare a read-only property
    public string Value { get; }

    public MyClass(string value)
    {
            // TODO: Initialize the read-only property
            Value = value;
    }
}

    public class Exercise
{
    public void PrintReadOnlyProperty()
    {
        // TODO: Create an instance of MyClass and print the property value
        MyClass myclass = new MyClass("Read-Only Property Value");
    }
}
