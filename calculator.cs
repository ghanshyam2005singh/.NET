using System;

class Calculator
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter first number:");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter second number:");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine($"Add: {a + b}");
        Console.WriteLine($"Subtract: {a - b}");
        Console.WriteLine($"Multiply: {a * b}");
        Console.WriteLine($"Divide: {(b != 0 ? a / b : "Cannot divide by zero")}");
    }
}