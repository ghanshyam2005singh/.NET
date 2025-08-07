using System;

class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    public void Greet()
    {
        Console.WriteLine($"Hello, my name is {Name} and I am {Age} years old.");
    }

    static void Main(string[] args)
    {
        Person p = new Person { Name = "Alice", Age = 25 };
        p.Greet();
    }
}