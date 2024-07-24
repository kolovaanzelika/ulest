/// Example of binding to an immutable value.
public class Person
{
    public readonly string Name;

    public Person(string name)
    {
        Name = name;
    }

    public void PrintName()
    {
        Console.WriteLine($"Name: {Name}");
    }
}

class Program
{
    static void Main()
    {
        var person = new Person("Alice");
        person.PrintName();
        // person.Name = "Bob"; // This will cause a compile-time error
    }
}
